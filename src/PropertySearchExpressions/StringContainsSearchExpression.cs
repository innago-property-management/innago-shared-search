#nullable enable
namespace Innago.Shared.Search.PropertySearchExpressions;

using System.Linq.Expressions;
using System.Reflection;

/// <summary>
///     Represents a search expression that checks if a string contains a value.
/// </summary>
public class StringContainsSearchExpression : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        MethodInfo method = typeof(string).GetMethod(nameof(string.Contains), [typeof(string)])!;

        ConstantExpression constant = Expression.Constant(this.Value);
        MethodCallExpression methodCall = Expression.Call(memberExpression, method, constant);

        return methodCall;
    }

    private string? Value { get; set; } = string.Empty;

    /// <summary>
    ///     Implicitly converts a <see cref="SearchValue{T}" /> to a <see cref="StringContainsSearchExpression" />.
    /// </summary>
    /// <param name="searchValue">
    ///     The <see cref="SearchValue{T}" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringContainsSearchExpression" /> that represents the converted <see cref="SearchValue{T}" />.
    /// </returns>
    public static implicit operator StringContainsSearchExpression(SearchValue<string> searchValue)
    {
        return new StringContainsSearchExpression { Value = searchValue.Value };
    }

    /// <summary>
    ///     Implicitly converts a <see cref="string" /> to a <see cref="StringContainsSearchExpression" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="string" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringContainsSearchExpression" /> that represents the converted <see cref="string" />.
    /// </returns>
    public static implicit operator StringContainsSearchExpression(string value)
    {
        return new StringContainsSearchExpression { Value = value };
    }
}