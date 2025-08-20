#nullable enable
namespace Innago.Shared.Search.PropertySearchExpressions;

using System.Linq.Expressions;

/// <summary>
///     Represents a search expression that compares a property to a value.
/// </summary>
/// <typeparam name="TMember">
///     The type of the property.
/// </typeparam>
public class LessThanOrEqualToSearchExpression<TMember> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        Expression constantExpression = Expression.Constant(this.Value);

        return Expression.LessThanOrEqual(memberExpression, constantExpression);
    }

    private TMember? Value { get; set; }

    /// <summary>
    ///     Implicitly converts a value to a <see cref="EqualToSearchExpression{TMember}" />.
    /// </summary>
    /// <param name="searchValue">
    ///     The <see cref="SearchValue{TMember}" />.
    /// </param>
    /// <returns>
    ///     The <see cref="EqualToSearchExpression{TMember}" />.
    /// </returns>
    public static implicit operator LessThanOrEqualToSearchExpression<TMember>(SearchValue<TMember> searchValue)
    {
        return new LessThanOrEqualToSearchExpression<TMember> { Value = searchValue.Value };
    }

    /// <summary>
    ///     Implicitly converts a value to a <see cref="EqualToSearchExpression{TMember}" />.
    /// </summary>
    /// <param name="value">
    ///     The value.
    /// </param>
    /// <returns>
    ///     The <see cref="EqualToSearchExpression{TMember}" />.
    /// </returns>
    public static implicit operator LessThanOrEqualToSearchExpression<TMember>(TMember? value)
    {
        return new LessThanOrEqualToSearchExpression<TMember> { Value = value };
    }
}