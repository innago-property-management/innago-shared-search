#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

namespace Taazaa.Shared.DevKit.Framework.Search.JsonConverters;

/// <summary>
///    Converts a <see cref="IComparableSearchCriteria{TMember}" /> to JSON.
/// </summary>
public class ComparableSearchExpressionJsonConverter : JsonConverterFactory
{
    /// <inheritdoc />
    public override bool CanConvert(Type typeToConvert)
    {
        bool isComparableSearchExpression = typeToConvert.IsGenericType && typeToConvert.GetGenericTypeDefinition() == typeof(IComparableSearchCriteria<>) ||
                                            typeToConvert.GetGenericTypeDefinition() == typeof(ValueSearchCriteria<>);

        return isComparableSearchExpression;
    }

    /// <inheritdoc />
    public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type paramType = typeToConvert.GetGenericArguments().Single();
        Type converterType = typeof(ConverterInternal<>).MakeGenericType(paramType);

        var converter = Activator.CreateInstance(converterType) as JsonConverter;

        return converter!;
    }

    private sealed class ConverterInternal<T> : JsonConverter<IComparableSearchCriteria<T>>
    {
        public override IComparableSearchCriteria<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            var retVal = new ValueSearchCriteria<T>();

            List<PropertyInfo> destProps = retVal.GetType().GetProperties().ToList();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return retVal;
                }

                string propName = reader.GetString() ?? string.Empty;

                PropertyInfo? prop = destProps.Single(p => p.Name.Equals(propName, StringComparison.InvariantCultureIgnoreCase));
                Type propType = prop.PropertyType;
                object? value = JsonSerializer.Deserialize(ref reader, propType, options);
                prop.SetValue(retVal, value);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, IComparableSearchCriteria<T> value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            foreach (PropertyInfo propertyInfo in value.GetType().GetProperties())
            {
                object? propValue = propertyInfo.GetValue(value);

                if (propValue is null)
                {
                    continue;
                }

                string propName = propertyInfo.Name;
                writer.WritePropertyName(options.PropertyNamingPolicy?.ConvertName(propName) ?? propName);

                JsonSerializer.Serialize(writer, propValue, propertyInfo.PropertyType, options);
            }

            writer.WriteEndObject();
        }
    }
}