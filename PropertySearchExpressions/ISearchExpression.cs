#nullable enable

using System.Linq.Expressions;
using JetBrains.Annotations;

namespace Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

/// <summary>
///     Defines a search expression.
/// </summary>
[PublicAPI]
public interface ISearchExpression
{
    /// <summary>
    ///     Gets the expression.
    /// </summary>
    /// <param name="memberExpression">
    ///     The member expression.
    /// </param>
    /// <returns>
    ///     The <see cref="Expression" />.
    /// </returns>
    public Expression GetExpression(MemberExpression memberExpression);
}