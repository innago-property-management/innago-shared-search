#nullable enable
using System.Linq.Expressions;

namespace Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

/// <summary>
///     Represents a search expression that compares a property to a value.
/// </summary>
/// <typeparam name="TMember">
///     The type of the property.
/// </typeparam>
public class GreaterThanOrEqualToSearchExpression<TMember> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        Expression constantExpression = Expression.Constant(this.Value);

        return Expression.GreaterThanOrEqual(memberExpression, constantExpression);
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
    public static implicit operator GreaterThanOrEqualToSearchExpression<TMember>(SearchValue<TMember> searchValue)
    {
        return new GreaterThanOrEqualToSearchExpression<TMember> { Value = searchValue.Value };
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
    public static implicit operator GreaterThanOrEqualToSearchExpression<TMember>(TMember? value)
    {
        return new GreaterThanOrEqualToSearchExpression<TMember> { Value = value };
    }
}