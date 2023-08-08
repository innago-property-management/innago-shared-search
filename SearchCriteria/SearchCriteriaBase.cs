#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using JetBrains.Annotations;

using Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

/// <summary>
///     The <see cref="SearchCriteriaBase{TSource}" /> class is used to specify search criteria for a
///     <typeparamref name="TSource" />
/// </summary>
/// <typeparam name="TSource">
///     The type of the source.
/// </typeparam>
[PublicAPI]
public abstract class SearchCriteriaBase<TSource>
{
    /// <summary>
    ///     Performs an implicit conversion from <see cref="SearchCriteriaBase{TSource}" /> to <see cref="Expression{Func}" />.
    /// </summary>
    /// <param name="searchCriteria">
    ///     The search criteria.
    /// </param>
    /// <returns>
    ///     The result of the conversion.
    /// </returns>
    public static implicit operator Expression<Func<TSource, bool>>(SearchCriteriaBase<TSource> searchCriteria)
    {
        return searchCriteria.GetPredicate();
    }

    private Expression<Func<TSource, bool>> GetPredicate()
    {
        IEnumerable<(string name, ISearchExpression expression)> searchExpressions =
            from propertyInfo in this.GetType().GetProperties()
            where typeof(ISearchExpression).IsAssignableFrom(propertyInfo.PropertyType)
            let searchExpression = propertyInfo.GetValue(this) as ISearchExpression
            where searchExpression != null
            select (name: propertyInfo.Name, expression: searchExpression);

        searchExpressions = searchExpressions.ToList();

        if (!searchExpressions.Any())
        {
            return source => true;
        }

        ParameterExpression sourceParameter = Expression.Parameter(typeof(TSource), "s");

        IList<Expression> sourcePredicateLambdas = new List<Expression>();

        foreach ((string name, ISearchExpression searchExpression) in searchExpressions)
        {
            MemberExpression sourceProperty = Expression.Property(sourceParameter, name);

            Expression sourcePredicate = searchExpression.GetExpression(sourceProperty).Reduce();

            if (sourcePredicate is ConstantExpression { Value: true })
            {
                continue;
            }

            sourcePredicateLambdas.Add(sourcePredicate);
        }

        Expression intersectionExpression = sourcePredicateLambdas.Aggregate(Expression.AndAlso).Reduce();

        Expression<Func<TSource, bool>> result = Expression.Lambda<Func<TSource, bool>>(intersectionExpression, sourceParameter);

        return result;
    }
}