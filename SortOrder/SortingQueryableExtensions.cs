#nullable enable

namespace Taazaa.Shared.DevKit.Framework.Search.SortOrder;

using System.Collections.Generic;
using System.Linq;

/// <summary>
///     The sorting queryable extensions.
/// </summary>
public static class SortingQueryableExtensions
{
    /// <summary>
    ///     Applies the sort.
    /// </summary>
    /// <param name="queryable">
    ///     The queryable to sort.
    /// </param>
    /// <param name="sortOrders">
    ///     The sort orders.
    /// </param>
    /// <typeparam name="T">
    ///     The type of the queryable.
    /// </typeparam>
    /// <returns>
    ///     The <see cref="IQueryable{T}" /> with the <see cref="SortOrderBase{TSource}" /> entries applied in order.
    /// </returns>
    public static IQueryable<T> ApplySort<T>(this IQueryable<T> queryable, IEnumerable<SortOrderBase<T>> sortOrders)
    {
        return sortOrders.Aggregate(queryable, (current, sortOrder) => sortOrder.Apply(current));
    }
}