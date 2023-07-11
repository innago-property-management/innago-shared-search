#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

using System.Linq.Expressions;
using System.Reflection;

using Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

/// <summary>
///     Represents a search expression that checks if a string does not contain a value.
/// </summary>
public class StringDoesNotContainSearchExpression : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        MethodInfo method = typeof(string).GetMethod(nameof(string.Contains), new[] { typeof(string) })!;

        ConstantExpression constant = Expression.Constant(this.Value);
        MethodCallExpression methodCall = Expression.Call(memberExpression, method, constant);

        UnaryExpression doesNotContain = Expression.Not(methodCall);

        return doesNotContain;
    }

    private string? Value { get; set; } = string.Empty;

    /// <summary>
    ///     Implicitly converts a <see cref="SearchValue{T}" /> to a <see cref="StringDoesNotContainSearchExpression" />.
    /// </summary>
    /// <param name="searchValue">
    ///     The <see cref="SearchValue{T}" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringDoesNotContainSearchExpression" /> that represents the converted <see cref="SearchValue{T}" />.
    /// </returns>
    public static implicit operator StringDoesNotContainSearchExpression(SearchValue<string> searchValue)
    {
        return new StringDoesNotContainSearchExpression { Value = searchValue.Value };
    }

    /// <summary>
    ///     Implicitly converts a <see cref="string" /> to a <see cref="StringDoesNotContainSearchExpression" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="string" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringDoesNotContainSearchExpression" /> that represents the converted <see cref="string" />.
    /// </returns>
    public static implicit operator StringDoesNotContainSearchExpression(string value)
    {
        return new StringDoesNotContainSearchExpression { Value = value };
    }
}