#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

/// <summary>
///     Logical OR of criteria.
/// </summary>
/// <typeparam name="TSearchCriteria">
///     The criteria type.
/// </typeparam>
/// <typeparam name="TSource">
///     The source type.
/// </typeparam>
public class OrSearchCriteria<TSearchCriteria, TSource>
    where TSearchCriteria : SearchCriteriaBase<TSource>
{
    private IEnumerable<TSearchCriteria>? Criteria { get; set; }

    /// <summary>
    ///     Implicitly converts the criteria to an expression for use in a where clause.
    /// </summary>
    /// <param name="searchCriteria">
    ///     The search criteria.
    /// </param>
    /// <returns></returns>
    public static implicit operator Expression<Func<TSource, bool>>(OrSearchCriteria<TSearchCriteria, TSource> searchCriteria)
    {
        return searchCriteria.GetPredicate();
    }

    /// <summary>
    ///     Implicitly converts an array of criteria to an <see cref="OrSearchCriteria{TSearchCriteria,TSource}"/>.
    /// </summary>
    /// <param name="criteria">
    ///     The criteria.
    /// </param>
    /// <returns>
    ///     The <see cref="OrSearchCriteria{TSearchCriteria,TSource}"/>.
    /// </returns>
    public static implicit operator OrSearchCriteria<TSearchCriteria, TSource>(TSearchCriteria[] criteria)
    {
        return new OrSearchCriteria<TSearchCriteria, TSource> { Criteria = criteria };
    }

    private Expression<Func<TSource, bool>> GetPredicate()
    {
        if (this.Criteria == null || this.Criteria.Any() is false)
        {
            return source => true;
        }

        ParameterExpression parameter = Expression.Parameter(typeof(TSource), "s");

        IEnumerable<Expression<Func<TSource, bool>>> lambdas = this.GetExpressionsAndReplaceParameter(parameter);

        Expression union = lambdas.Select(expression => expression.Body)
            .Aggregate((agg, next) => Expression.OrElse(agg, next).Reduce());

        return Expression.Lambda<Func<TSource, bool>>(union, parameter);
    }

    private IEnumerable<Expression<Func<TSource, bool>>> GetExpressionsAndReplaceParameter(ParameterExpression parameter)
    {
        IEnumerable<Expression<Func<TSource, bool>>> lambdas = this.Criteria!.Select(criteria => (Expression<Func<TSource, bool>>)criteria);

        var replacer = new ParameterReplacingExpressionVisitor(parameter);

        return lambdas.Select(expression => replacer.VisitAndConvert(expression, null));
    }
}