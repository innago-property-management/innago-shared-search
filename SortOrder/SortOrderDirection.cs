#nullable enable

namespace Taazaa.Shared.DevKit.Framework.Search.SortOrder;

using JetBrains.Annotations;

/// <summary>
///     The direction of the sort order.
/// </summary>
[PublicAPI]
public enum SortOrderDirection
{
    /// <summary>
    ///     Ascending sort order.
    /// </summary>
    Ascending = 0,

    /// <summary>
    ///     Descending sort order.
    /// </summary>
    Descending = 1,
}