#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

namespace Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

/// <summary>
///     Represents a search expression that is a logical AND of other search expressions.
/// </summary>
/// <typeparam name="T">
///     The type of the property.
/// </typeparam>
public class AndSearchExpression<T> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        if (this.Expressions is null || !this.Expressions.Any())
        {
            return Expression.Constant(false);
        }

        return this.Expressions.Aggregate((Expression)Expression.Constant(true),
            (agg, next) => Expression.AndAlso(agg, (next as ISearchExpression).GetExpression(memberExpression)));
    }

    private IEnumerable<ComparableSearchCriteria<T>>? Expressions { get; set; }

    /// <summary>
    ///     Implicitly converts an array of <see cref="ComparableSearchCriteria{TMember}" /> to an
    /// </summary>
    /// <param name="clauses">
    ///     The clauses to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="AndSearchExpression{T}" />.
    /// </returns>
    public static implicit operator AndSearchExpression<T>(ComparableSearchCriteria<T>[] clauses)
    {
        return new AndSearchExpression<T>
        {
            Expressions = new List<ComparableSearchCriteria<T>>(clauses),
        };
    }
}