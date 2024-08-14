#nullable enable
using System.Linq.Expressions;
using System.Reflection;

namespace Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

/// <summary>
///     Represents a search expression that checks if a string DoesNotEndWith a value.
/// </summary>
public class StringDoesNotEndWithSearchExpression : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        MethodInfo method = typeof(string).GetMethod(nameof(string.EndsWith), [typeof(string)])!;

        ConstantExpression constant = Expression.Constant(this.Value);
        MethodCallExpression methodCall = Expression.Call(memberExpression, method, constant);

        UnaryExpression doesNotEndWith = Expression.Not(methodCall);

        return doesNotEndWith;
    }

    private string? Value { get; set; } = string.Empty;

    /// <summary>
    ///     Implicitly converts a <see cref="SearchValue{T}" /> to a <see cref="StringDoesNotEndWithSearchExpression" />.
    /// </summary>
    /// <param name="searchValue">
    ///     The <see cref="SearchValue{T}" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringDoesNotEndWithSearchExpression" /> that represents the converted <see cref="SearchValue{T}" />.
    /// </returns>
    public static implicit operator StringDoesNotEndWithSearchExpression(SearchValue<string> searchValue)
    {
        return new StringDoesNotEndWithSearchExpression { Value = searchValue.Value };
    }

    /// <summary>
    ///     Implicitly converts a <see cref="string" /> to a <see cref="StringDoesNotEndWithSearchExpression" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="string" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringDoesNotEndWithSearchExpression" /> that represents the converted <see cref="string" />.
    /// </returns>
    public static implicit operator StringDoesNotEndWithSearchExpression(string value)
    {
        return new StringDoesNotEndWithSearchExpression { Value = value };
    }
}