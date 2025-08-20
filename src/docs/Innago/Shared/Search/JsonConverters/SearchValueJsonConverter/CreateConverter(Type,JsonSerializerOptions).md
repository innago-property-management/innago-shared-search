#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.JsonConverters](../index.md 'Innago\.Shared\.Search\.JsonConverters').[SearchValueJsonConverter](index.md 'Innago\.Shared\.Search\.JsonConverters\.SearchValueJsonConverter')

## SearchValueJsonConverter\.CreateConverter\(Type, JsonSerializerOptions\) Method

Creates a converter for a specified type\.

```csharp
public override System.Text.Json.Serialization.JsonConverter CreateConverter(System.Type typeToConvert, System.Text.Json.JsonSerializerOptions options);
```
#### Parameters

<a name='Innago.Shared.Search.JsonConverters.SearchValueJsonConverter.CreateConverter(System.Type,System.Text.Json.JsonSerializerOptions).typeToConvert'></a>

`typeToConvert` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type handled by the converter\.

<a name='Innago.Shared.Search.JsonConverters.SearchValueJsonConverter.CreateConverter(System.Type,System.Text.Json.JsonSerializerOptions).options'></a>

`options` [System\.Text\.Json\.JsonSerializerOptions](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.jsonserializeroptions 'System\.Text\.Json\.JsonSerializerOptions')

The serialization options\.

#### Returns
[System\.Text\.Json\.Serialization\.JsonConverter](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter 'System\.Text\.Json\.Serialization\.JsonConverter')  
A converter for which [System\.Text\.Json\.Serialization\.JsonConverter\.CanConvert\(System\.Type\)](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.serialization.jsonconverter.canconvert#system-text-json-serialization-jsonconverter-canconvert(system-type) 'System\.Text\.Json\.Serialization\.JsonConverter\.CanConvert\(System\.Type\)') returns `true` for the specified type\.