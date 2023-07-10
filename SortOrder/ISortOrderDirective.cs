namespace Taazaa.Shared.DevKit.Framework.Search.SortOrder;

using System.Linq;

using JetBrains.Annotations;

/// <summary>
///     The interface for a sort order directive.
/// </summary>
[PublicAPI]
public interface ISortOrderDirective
{
    /// <summary>
    ///     Gets or sets the Direction.
    /// </summary>
    public SortOrderDirection Direction { get; set; }

    /// <summary>
    ///     Applies the sort order directive to the queryable.
    /// </summary>
    /// <param name="queryable">
    ///     The queryable to apply the sort order directive to.
    /// </param>
    /// <param name="propertyName">
    ///     The name of the property to apply the sort order directive to.
    /// </param>
    /// <typeparam name="TSource">
    ///     The type of the source.
    /// </typeparam>
    /// <returns>
    ///     The queryable with the sort order directive applied.
    /// </returns>
    IOrderedQueryable<TSource> Apply<TSource>(IQueryable<TSource> queryable, string propertyName);
}