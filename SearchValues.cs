#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search;

using System.Collections.Generic;

/// <summary>
///     Represents a set of values that can be used in a search.
/// </summary>
/// <typeparam name="TMember">
///     The type of the values.
/// </typeparam>
public record SearchValues<TMember>
{
    /// <summary>
    ///     Gets or sets the values.
    /// </summary>
    public IEnumerable<TMember?>? Values { get; private set; }

    /// <summary>
    ///     Implicitly converts a value to a <see cref="SearchValues{TMember}" />.
    /// </summary>
    /// <param name="values">
    ///     The values.
    /// </param>
    /// <returns>
    ///     The <see cref="SearchValues{TMember}" />.
    /// </returns>
    public static implicit operator SearchValues<TMember>(TMember?[] values)
    {
        return new SearchValues<TMember>
        {
            Values = values,
        };
    }
}