namespace Taazaa.Shared.DevKit.Framework.Search;

#nullable enable
using System.Text.Json.Serialization;

using Taazaa.Shared.DevKit.Framework.Search.JsonConverters;

/// <summary>
///     Represents a value that can be used in a search.
/// </summary>
/// <typeparam name="TMember">
///     The type of the value.
/// </typeparam>
[JsonConverter(typeof(SearchValueJsonConverter))]
public record SearchValue<TMember>
{
    /// <summary>
    ///     Gets or sets the value.
    /// </summary>
    public TMember? Value { get; internal set; }

    /// <summary>
    ///     Implicitly converts a value to a <see cref="SearchValue{TMember}" />.
    /// </summary>
    /// <param name="value">
    ///     The value.
    /// </param>
    /// <returns>
    ///     The <see cref="SearchValue{TMember}" />.
    /// </returns>
    public static implicit operator SearchValue<TMember>(TMember value)
    {
        return new SearchValue<TMember> { Value = value };
    }
}