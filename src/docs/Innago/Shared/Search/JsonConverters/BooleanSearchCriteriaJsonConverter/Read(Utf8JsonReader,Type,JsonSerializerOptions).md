#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.JsonConverters](../index.md 'Innago\.Shared\.Search\.JsonConverters').[BooleanSearchCriteriaJsonConverter](index.md 'Innago\.Shared\.Search\.JsonConverters\.BooleanSearchCriteriaJsonConverter')

## BooleanSearchCriteriaJsonConverter\.Read\(Utf8JsonReader, Type, JsonSerializerOptions\) Method

Reads and converts the JSON to type [BooleanSearchCriteria](../../SearchCriteria/BooleanSearchCriteria/index.md 'Innago\.Shared\.Search\.SearchCriteria\.BooleanSearchCriteria')\.

```csharp
public override Innago.Shared.Search.SearchCriteria.BooleanSearchCriteria Read(ref System.Text.Json.Utf8JsonReader reader, System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options);
```
#### Parameters

<a name='Innago.Shared.Search.JsonConverters.BooleanSearchCriteriaJsonConverter.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions).reader'></a>

`reader` [System\.Text\.Json\.Utf8JsonReader](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.utf8jsonreader 'System\.Text\.Json\.Utf8JsonReader')

The JSON reader\.

<a name='Innago.Shared.Search.JsonConverters.BooleanSearchCriteriaJsonConverter.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions).typeToConvert'></a>

`typeToConvert` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to convert\.

<a name='Innago.Shared.Search.JsonConverters.BooleanSearchCriteriaJsonConverter.Read(System.Text.Json.Utf8JsonReader,System.Type,System.Text.Json.JsonSerializerOptions).options'></a>

`options` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The serialization options\.

#### Returns
[BooleanSearchCriteria](../../SearchCriteria/BooleanSearchCriteria/index.md 'Innago\.Shared\.Search\.SearchCriteria\.BooleanSearchCriteria')  
The converted [BooleanSearchCriteria](../../SearchCriteria/BooleanSearchCriteria/index.md 'Innago\.Shared\.Search\.SearchCriteria\.BooleanSearchCriteria')\.