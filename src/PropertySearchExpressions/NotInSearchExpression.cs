#nullable enable
namespace Innago.Shared.Search.PropertySearchExpressions;

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

/// <summary>
///     Represents a search expression that compares a property to a value.
/// </summary>
/// <typeparam name="TSource">
///     The type of the property.
/// </typeparam>
public class NotInSearchExpression<TSource> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        MethodInfo method = typeof(Enumerable).GetMethods().First(m => m.Name == "Contains" && m.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(TSource));

        ConstantExpression constant = Expression.Constant(this.Values);
        MethodCallExpression methodCall = Expression.Call(null, method, constant, memberExpression);

        UnaryExpression doesNotContain = Expression.Not(methodCall);

        return doesNotContain;
    }

    private IEnumerable<TSource?>? Values { get; set; }

    /// <summary>
    ///     Implicitly converts a <see cref="SearchValues{TSource}" /> to a <see cref="InSearchExpression{TSource}" />.
    /// </summary>
    /// <param name="searchValues">
    ///     The <see cref="SearchValues{TSource}" /> to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="InSearchExpression{TSource}" /> that was created.
    /// </returns>
    public static implicit operator NotInSearchExpression<TSource>(SearchValues<TSource> searchValues)
    {
        return new NotInSearchExpression<TSource> { Values = searchValues.Values };
    }

    /// <summary>
    ///     Implicitly converts a <typeparamref name="TSource" /> array to a <see cref="InSearchExpression{TSource}" />.
    /// </summary>
    /// <param name="values">
    ///     The <typeparamref name="TSource" /> array to convert.
    /// </param>
    /// <returns>
    ///     The <see cref="InSearchExpression{TSource}" /> that was created.
    /// </returns>
    public static implicit operator NotInSearchExpression<TSource>(TSource[] values)
    {
        return new NotInSearchExpression<TSource> { Values = values };
    }
}