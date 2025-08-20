#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.PropertySearchExpressions](../index.md 'Innago\.Shared\.Search\.PropertySearchExpressions').[NotInSearchExpression&lt;TSource&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>')

## NotInSearchExpression\<TSource\>\.implicit operator NotInSearchExpression\<TSource\>\(TSource\[\]\) Operator

Implicitly converts a [TSource](index.md#Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.TSource 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.TSource') array to a [InSearchExpression&lt;TSource&gt;](../InSearchExpression_TSource_/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.InSearchExpression\<TSource\>')\.

```csharp
public static Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression<TSource> implicit operator Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression<TSource>(TSource[] values);
```
#### Parameters

<a name='Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.op_ImplicitInnago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_(TSource[]).values'></a>

`values` [TSource](index.md#Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.TSource 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.TSource')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The [TSource](index.md#Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.TSource 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.TSource') array to convert\.

#### Returns
[Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression&lt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>')[TSource](index.md#Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.TSource 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.TSource')[&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>')  
The [InSearchExpression&lt;TSource&gt;](../InSearchExpression_TSource_/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.InSearchExpression\<TSource\>') that was created\.