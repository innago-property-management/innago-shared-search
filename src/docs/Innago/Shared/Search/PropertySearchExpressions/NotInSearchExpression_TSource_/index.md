#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.PropertySearchExpressions](../index.md 'Innago\.Shared\.Search\.PropertySearchExpressions')

## NotInSearchExpression\<TSource\> Class

Represents a search expression that compares a property to a value\.

```csharp
public class NotInSearchExpression<TSource> : Innago.Shared.Search.PropertySearchExpressions.ISearchExpression
```
#### Type parameters

<a name='Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.TSource'></a>

`TSource`

The type of the property\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; NotInSearchExpression\<TSource\>

Implements [ISearchExpression](../ISearchExpression/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.ISearchExpression')

| Operators | |
| :--- | :--- |
| [implicit operator NotInSearchExpression&lt;TSource&gt;\(SearchValues&lt;TSource&gt;\)](implicitoperatorNotInSearchExpression_TSource_(SearchValues_TSource_).md 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.op\_Implicit Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\(Innago\.Shared\.Search\.SearchValues\<TSource\>\)') | Implicitly converts a [SearchValues&lt;TMember&gt;](../../SearchValues_TMember_/index.md 'Innago\.Shared\.Search\.SearchValues\<TMember\>') to a [InSearchExpression&lt;TSource&gt;](../InSearchExpression_TSource_/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.InSearchExpression\<TSource\>')\. |
| [implicit operator NotInSearchExpression&lt;TSource&gt;\(TSource\[\]\)](implicitoperatorNotInSearchExpression_TSource_(TSource[]).md 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.op\_Implicit Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\(TSource\[\]\)') | Implicitly converts a [TSource](index.md#Innago.Shared.Search.PropertySearchExpressions.NotInSearchExpression_TSource_.TSource 'Innago\.Shared\.Search\.PropertySearchExpressions\.NotInSearchExpression\<TSource\>\.TSource') array to a [InSearchExpression&lt;TSource&gt;](../InSearchExpression_TSource_/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.InSearchExpression\<TSource\>')\. |
