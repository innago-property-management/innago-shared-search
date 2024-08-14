#nullable enable
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

namespace Taazaa.Shared.DevKit.Framework.Search.JsonConverters;

/// <summary>
///     Converts a <see cref="BooleanSearchCriteria" /> to or from JSON.
/// </summary>
public class BooleanSearchCriteriaJsonConverter : JsonConverter<BooleanSearchCriteria>
{
    /// <summary>
    ///     Reads and converts the JSON to type <see cref="BooleanSearchCriteria" />.
    /// </summary>
    /// <param name="reader">
    ///     The JSON reader.
    /// </param>
    /// <param name="typeToConvert">
    ///     The type to convert.
    /// </param>
    /// <param name="options">
    ///     The serialization options.
    /// </param>
    /// <returns>
    ///     The converted <see cref="BooleanSearchCriteria" />.
    /// </returns>
    public override BooleanSearchCriteria Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        bool value = reader.GetBoolean();

        return new BooleanSearchCriteria { Value = value };
    }

    /// <summary>
    ///     Writes a <see cref="BooleanSearchCriteria" /> object to JSON.
    /// </summary>
    /// <param name="writer">
    ///     The JSON writer.
    /// </param>
    /// <param name="value">
    ///     The <see cref="BooleanSearchCriteria" /> object to convert.
    /// </param>
    /// <param name="options">
    ///     The serialization options.
    /// </param>
    public override void Write(Utf8JsonWriter writer, BooleanSearchCriteria value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value.Value, value.Value?.GetType() ?? typeof(object), options);
    }
}