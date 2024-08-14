#nullable enable
using System;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Taazaa.Shared.DevKit.Framework.Search.JsonConverters;

/// <summary>
///     Converts a <see cref="SearchValue{TMember}" /> to or from JSON.
/// </summary>
public class SearchValueJsonConverter : JsonConverterFactory
{
    /// <summary>
    ///     Determines whether the specified type can be converted to a <see cref="SearchValue{TMember}" />.
    /// </summary>
    /// <param name="typeToConvert">
    ///     The type to convert.
    /// </param>
    /// <returns>
    ///     <c>true</c> if the specified type can be converted to a <see cref="SearchValue{TMember}" />; otherwise,
    ///     <c>false</c>.
    /// </returns>
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(SearchValue<>);
    }

    /// <summary>
    ///     Creates a converter for a specified type.
    /// </summary>
    /// <param name="typeToConvert">
    ///     The type handled by the converter.
    /// </param>
    /// <param name="options">
    ///     The serialization options.
    /// </param>
    /// <returns>
    ///     A converter for which <see cref="JsonConverter.CanConvert(Type)" /> returns <c>true</c> for the specified type.
    /// </returns>
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type paramType = typeToConvert.GetGenericArguments().Single();
        Type converterType = typeof(ConverterInternal<>).MakeGenericType(paramType);

        var converter = Activator.CreateInstance(converterType) as JsonConverter;

        return converter!;
    }

    private sealed class ConverterInternal<T> : JsonConverter<SearchValue<T>>
    {
        public override SearchValue<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var retVal = new SearchValue<T>
            {
                Value = (T)JsonSerializer.Deserialize(ref reader, typeof(T), options)!,
            };

            return retVal;
        }

        public override void Write(Utf8JsonWriter writer, SearchValue<T> value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value.Value, typeof(T), options);
        }
    }
}