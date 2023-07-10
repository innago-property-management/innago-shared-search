#nullable enable

namespace Taazaa.Shared.DevKit.Framework.Search.SortOrder;

using System;
using System.Linq;
using System.Linq.Expressions;

/// <summary>
///    The sort order directive.
/// </summary>
/// <typeparam name="TProperty">
///    The type of the property.
/// </typeparam>
// TODO JsonConverter
public sealed class SortOrderDirective<TProperty> : ISortOrderDirective
{
    /// <inheritdoc />
    public SortOrderDirection Direction { get; set; }

    /// <inheritdoc />
    public IOrderedQueryable<TSource> Apply<TSource>(IQueryable<TSource> queryable, string propertyName)
    {
        if (queryable.Expression.Type == typeof(IOrderedQueryable<TSource>))
        {
            return this.Direction == SortOrderDirection.Ascending
                ? (queryable as IOrderedQueryable<TSource>)!.ThenBy(this.GetSelector<TSource>(propertyName))
                : (queryable as IOrderedQueryable<TSource>)!.ThenByDescending(this.GetSelector<TSource>(propertyName));
        }

        return this.Direction == SortOrderDirection.Ascending
            ? queryable.OrderBy(this.GetSelector<TSource>(propertyName))
            : queryable.OrderByDescending(this.GetSelector<TSource>(propertyName));
    }

    /// <summary>
    ///   Implicitly converts a <see cref="SortOrderDirection" /> to a <see cref="SortOrderDirective{TProperty}" />.
    /// </summary>
    /// <param name="direction">
    ///   The direction.
    /// </param>
    /// <returns>
    ///   The <see cref="SortOrderDirective{TProperty}" />.
    /// </returns>
    public static implicit operator SortOrderDirective<TProperty>(SortOrderDirection direction)
    {
        return new SortOrderDirective<TProperty> { Direction = direction };
    }

    internal Expression<Func<TSource, TProperty>> GetSelector<TSource>(string propertyName)
    {
        ParameterExpression parameter = Expression.Parameter(typeof(TSource));
        MemberExpression property = Expression.Property(parameter, propertyName);
        Expression<Func<TSource, TProperty>> lambda = Expression.Lambda<Func<TSource, TProperty>>(property, parameter);

        return lambda;
    }
}