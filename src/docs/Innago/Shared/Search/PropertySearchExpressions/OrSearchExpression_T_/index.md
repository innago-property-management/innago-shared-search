#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.PropertySearchExpressions](../index.md 'Innago\.Shared\.Search\.PropertySearchExpressions')

## OrSearchExpression\<T\> Class

Represents a search expression that is a logical OR of other search expressions\.

```csharp
public class OrSearchExpression<T> : Innago.Shared.Search.PropertySearchExpressions.ISearchExpression
```
#### Type parameters

<a name='Innago.Shared.Search.PropertySearchExpressions.OrSearchExpression_T_.T'></a>

`T`

The type of the property\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; OrSearchExpression\<T\>

Implements [ISearchExpression](../ISearchExpression/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.ISearchExpression')

| Operators | |
| :--- | :--- |
| [implicit operator OrSearchExpression&lt;T&gt;\(ComparableSearchCriteria&lt;T&gt;\[\]\)](implicitoperatorOrSearchExpression_T_(ComparableSearchCriteria_T_[]).md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>\.op\_Implicit Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>\(Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<T\>\[\]\)') | Implicitly converts an array of [ComparableSearchCriteria&lt;TMember&gt;](../../TypeSearchExpressions/ComparableSearchCriteria_TMember_/index.md 'Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<TMember\>') to an [OrSearchExpression&lt;T&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>')\. |
