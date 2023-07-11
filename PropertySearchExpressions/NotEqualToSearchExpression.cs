#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

using System.Linq.Expressions;

/// <summary>
///     Represents a search expression that compares a property to a value.
/// </summary>
/// <typeparam name="TMember">
///     The type of the property.
/// </typeparam>
public class NotEqualToSearchExpression<TMember> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        Expression constantExpression = Expression.Constant(this.Value);

        return Expression.NotEqual(memberExpression, constantExpression);
    }

    private TMember? Value { get; set; }

    /// <summary>
    ///     Implicitly converts a <see cref="SearchValue{TMember}" /> to a <see cref="NotEqualToSearchExpression{TMember}" />.
    /// </summary>
    /// <param name="searchValue">
    ///     The <see cref="SearchValue{TMember}" />.
    /// </param>
    /// <returns>
    ///     The <see cref="NotEqualToSearchExpression{TMember}" />.
    /// </returns>
    public static implicit operator NotEqualToSearchExpression<TMember>(SearchValue<TMember?> searchValue)
    {
        return new NotEqualToSearchExpression<TMember>
        {
            Value = searchValue.Value,
        };
    }

    /// <summary>
    ///     Implicitly converts a value to a <see cref="NotEqualToSearchExpression{TMember}" />.
    /// </summary>
    /// <param name="value">
    ///     The value.
    /// </param>
    /// <returns>
    ///     The <see cref="NotEqualToSearchExpression{TMember}" />.
    /// </returns>
    public static implicit operator NotEqualToSearchExpression<TMember>(TMember? value)
    {
        return new NotEqualToSearchExpression<TMember>
        {
            Value = value,
        };
    }
}