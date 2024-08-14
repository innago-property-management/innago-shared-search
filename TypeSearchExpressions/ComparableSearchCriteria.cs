#nullable enable

using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using JetBrains.Annotations;
using Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;

namespace Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

/// <summary>
///     A search expression that combines multiple <see cref="ComparableSearchCriteria{TMember}" />s into a single
/// </summary>
/// <typeparam name="TMember">
///     The type of the property.
/// </typeparam>
[PublicAPI]
public class ComparableSearchCriteria<TMember> : ISearchExpression
{
    Expression ISearchExpression.GetExpression(MemberExpression memberExpression)
    {
        IEnumerable<(string name, ISearchExpression expression)> searchExpressions =
#pragma warning disable S3011
            from propertyInfo in this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
#pragma warning restore S3011
            where typeof(ISearchExpression).IsAssignableFrom(propertyInfo.PropertyType)
            let searchExpression = propertyInfo.GetValue(this) as ISearchExpression
            where searchExpression != null
            select (name: propertyInfo.Name, expression: searchExpression);

        searchExpressions = searchExpressions.ToList();

        if (!searchExpressions.Any())
        {
            return Expression.Constant(true);
        }

        Expression result = searchExpressions.Select(s => s.expression.GetExpression(memberExpression))
            .Aggregate(Expression.AndAlso);

        return result.Reduce();
    }

    internal AndSearchExpression<TMember>? AndSearchExpression { [UsedImplicitly] get; set; }
    internal EqualToSearchExpression<TMember>? EqualToSearchExpression { [UsedImplicitly] get; set; }

    internal GreaterThanOrEqualToSearchExpression<TMember>? GreaterThanOrEqualToSearchExpression { [UsedImplicitly] get; set; }

    internal GreaterThanSearchExpression<TMember>? GreaterThanSearchExpression { [UsedImplicitly] get; set; }

    internal InSearchExpression<TMember>? InSearchExpression { [UsedImplicitly] get; set; }

    internal LessThanOrEqualToSearchExpression<TMember>? LessThanOrEqualToSearchExpression { [UsedImplicitly] get; set; }

    internal LessThanSearchExpression<TMember>? LessThanSearchExpression { [UsedImplicitly] get; set; }

    internal NotEqualToSearchExpression<TMember>? NotEqualToSearchExpression { [UsedImplicitly] get; set; }

    internal NotInSearchExpression<TMember>? NotInSearchExpression { [UsedImplicitly] get; set; }

    internal OrSearchExpression<TMember>? OrSearchExpression { [UsedImplicitly] get; set; }
}