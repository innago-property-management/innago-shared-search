#nullable enable

using JetBrains.Annotations;

namespace Taazaa.Shared.DevKit.Framework.Search.SortOrder;

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