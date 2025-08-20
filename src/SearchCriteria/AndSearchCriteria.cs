#nullable enable

namespace Innago.Shared.Search.SearchCriteria;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

/// <summary>
///     Logical AND of criteria
/// </summary>
/// <typeparam name="TSearchCriteria">
///     The type of the search criteria.
/// </typeparam>
/// <typeparam name="TSource">
///     The type of the source.
/// </typeparam>
public class AndSearchCriteria<TSearchCriteria, TSource>
    where TSearchCriteria : SearchCriteriaBase<TSource>
{
    private IEnumerable<TSearchCriteria>? Criteria { get; set; }

    /// <summary>
    ///     Implicitly converts an <see cref="AndSearchCriteria{TSearchCriteria,TSource}" /> to an expression for use in a
    ///     where clause.
    /// </summary>
    /// <param name="searchCriteria">
    ///     The search criteria.
    /// </param>
    /// <returns>
    ///     An expression.
    /// </returns>
    public static implicit operator Expression<Func<TSource, bool>>(AndSearchCriteria<TSearchCriteria, TSource> searchCriteria)
    {
        return searchCriteria.GetPredicate();
    }

    /// <summary>
    ///     Implicitly converts
    /// </summary>
    /// <param name="criteria"></param>
    /// <returns></returns>
    public static implicit operator AndSearchCriteria<TSearchCriteria, TSource>(TSearchCriteria[] criteria)
    {
        return new AndSearchCriteria<TSearchCriteria, TSource> { Criteria = criteria };
    }

    private IEnumerable<Expression<Func<TSource, bool>>> GetExpressionsAndReplaceParameter(ParameterExpression parameter)
    {
        IEnumerable<Expression<Func<TSource, bool>>> lambdas = this.Criteria!.Select(criteria => (Expression<Func<TSource, bool>>)criteria);

        var replacer = new ParameterReplacingExpressionVisitor(parameter);

        return lambdas.Select(expression => replacer.VisitAndConvert(expression, null));
    }

    private Expression<Func<TSource, bool>> GetPredicate()
    {
        if (this.Criteria == null || !this.Criteria.Any())
        {
            return source => true;
        }

        ParameterExpression parameter = Expression.Parameter(typeof(TSource), "s");

        IEnumerable<Expression<Func<TSource, bool>>> lambdas = this.GetExpressionsAndReplaceParameter(parameter);

        Expression intersection = lambdas.Select(expression => expression.Body)
            .Aggregate((agg, next) => Expression.AndAlso(agg, next).Reduce());

        return Expression.Lambda<Func<TSource, bool>>(intersection, parameter);
    }
}