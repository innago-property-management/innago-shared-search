#nullable enable
namespace Innago.Shared.Search.PropertySearchExpressions;

using System.Linq.Expressions;

/// <summary>
///     Represents a search expression that compares a property to a value.
/// </summary>
/// <typeparam name="TMember">
///     The type of the property.
/// </typeparam>
public class GreaterThanSearchExpression<TMember> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        Expression constantExpression = Expression.Constant(this.Value);

        return Expression.GreaterThan(memberExpression, constantExpression);
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
    public static implicit operator GreaterThanSearchExpression<TMember>(SearchValue<TMember> searchValue)
    {
        return new GreaterThanSearchExpression<TMember> { Value = searchValue.Value };
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
    public static implicit operator GreaterThanSearchExpression<TMember>(TMember? value)
    {
        return new GreaterThanSearchExpression<TMember> { Value = value };
    }
}