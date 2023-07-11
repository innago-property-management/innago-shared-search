#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

/// <summary>
///     Represents a search expression that is a logical OR of other search expressions.
/// </summary>
/// <typeparam name="T">
///     The type of the property.
/// </typeparam>
public class OrSearchExpression<T> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        if (this.Expressions is null || !this.Expressions.Any())
        {
            return Expression.Constant(false);
        }

        return this.Expressions.Select(e => (e as ISearchExpression).GetExpression(memberExpression)).Aggregate(
            Expression.OrElse);
    }

    private IEnumerable<ComparableSearchExpression<T>>? Expressions { get; set; }

    /// <summary>
    ///     Implicitly converts an array of <see cref="ComparableSearchExpression{T}" /> to an
    ///     <see cref="OrSearchExpression{T}" />.
    /// </summary>
    /// <param name="clauses">
    ///     The clauses to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="OrSearchExpression{T}" />.
    /// </returns>
    public static implicit operator OrSearchExpression<T>(ComparableSearchExpression<T>[] clauses)
    {
        return new OrSearchExpression<T>
        {
            Expressions = new List<ComparableSearchExpression<T>>(clauses),
        };
    }
}