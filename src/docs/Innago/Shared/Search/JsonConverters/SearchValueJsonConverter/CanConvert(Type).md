#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.JsonConverters](../index.md 'Innago\.Shared\.Search\.JsonConverters').[SearchValueJsonConverter](index.md 'Innago\.Shared\.Search\.JsonConverters\.SearchValueJsonConverter')

## SearchValueJsonConverter\.CanConvert\(Type\) Method

Determines whether the specified type can be converted to a [SearchValue&lt;TMember&gt;](../../SearchValue_TMember_/index.md 'Innago\.Shared\.Search\.SearchValue\<TMember\>')\.

```csharp
public override bool CanConvert(System.Type typeToConvert);
```
#### Parameters

<a name='Innago.Shared.Search.JsonConverters.SearchValueJsonConverter.CanConvert(System.Type).typeToConvert'></a>

`typeToConvert` [System\.Type](https://learn.microsoft.com/en-us/dotnet/api/system.type 'System\.Type')

The type to convert\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the specified type can be converted to a [SearchValue&lt;TMember&gt;](../../SearchValue_TMember_/index.md 'Innago\.Shared\.Search\.SearchValue\<TMember\>'); otherwise,
                `false`\.