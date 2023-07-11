#nullable enable

namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

using JetBrains.Annotations;

/// <summary>
///    Represents a search criteria that can be used to search for a comparable value.
/// </summary>
/// <typeparam name="TMember">
///    The type of the member to search.
/// </typeparam>
[PublicAPI]
public interface IComparableSearchCriteria<TMember>
{
    /// <summary>
    ///   Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? EqualTo { get; set; }

    /// <summary>
    ///  Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? GreaterThan { get; set; }

    /// <summary>
    /// Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? GreaterThanOrEqualTo { get; set; }

    /// <summary>
    /// Gets or sets the value to search for.
    /// </summary>
    public SearchValues<TMember>? In { get; set; }

    /// <summary>
    /// Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? LessThan { get; set; }

    /// <summary>
    /// Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? LessThanOrEqualTo { get; set; }

    /// <summary>
    /// Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? NotEqualTo { get; set; }

    /// <summary>
    /// Gets or sets the value to search for.
    /// </summary>
    public SearchValues<TMember>? NotIn { get; set; }
}