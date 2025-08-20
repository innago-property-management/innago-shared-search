#nullable enable
namespace Innago.Shared.Search.PropertySearchExpressions;

using System.Linq.Expressions;
using System.Reflection;

/// <summary>
///     Represents a search expression that checks if a string EndsWith a value.
/// </summary>
public class StringEndsWithSearchExpression : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        MethodInfo method = typeof(string).GetMethod(nameof(string.EndsWith), [typeof(string)])!;

        ConstantExpression constant = Expression.Constant(this.Value);
        MethodCallExpression methodCall = Expression.Call(memberExpression, method, constant);

        return methodCall;
    }

    private string? Value { get; set; } = string.Empty;

    /// <summary>
    ///     Implicitly converts a <see cref="SearchValue{T}" /> to a <see cref="StringEndsWithSearchExpression" />.
    /// </summary>
    /// <param name="searchValue">
    ///     The <see cref="SearchValue{T}" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringEndsWithSearchExpression" /> that represents the converted <see cref="SearchValue{T}" />.
    /// </returns>
    public static implicit operator StringEndsWithSearchExpression(SearchValue<string> searchValue)
    {
        return new StringEndsWithSearchExpression { Value = searchValue.Value };
    }

    /// <summary>
    ///     Implicitly converts a <see cref="string" /> to a <see cref="StringEndsWithSearchExpression" />.
    /// </summary>
    /// <param name="value">
    ///     The <see cref="string" /> to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="StringEndsWithSearchExpression" /> that represents the converted <see cref="string" />.
    /// </returns>
    public static implicit operator StringEndsWithSearchExpression(string value)
    {
        return new StringEndsWithSearchExpression { Value = value };
    }
}