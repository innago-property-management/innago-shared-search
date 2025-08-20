#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.PropertySearchExpressions](../index.md 'Innago\.Shared\.Search\.PropertySearchExpressions')

## AndSearchExpression\<T\> Class

Represents a search expression that is a logical AND of other search expressions\.

```csharp
public class AndSearchExpression<T> : Innago.Shared.Search.PropertySearchExpressions.ISearchExpression
```
#### Type parameters

<a name='Innago.Shared.Search.PropertySearchExpressions.AndSearchExpression_T_.T'></a>

`T`

The type of the property\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; AndSearchExpression\<T\>

Implements [ISearchExpression](../ISearchExpression/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.ISearchExpression')

| Operators | |
| :--- | :--- |
| [implicit operator AndSearchExpression&lt;T&gt;\(ComparableSearchCriteria&lt;T&gt;\[\]\)](implicitoperatorAndSearchExpression_T_(ComparableSearchCriteria_T_[]).md 'Innago\.Shared\.Search\.PropertySearchExpressions\.AndSearchExpression\<T\>\.op\_Implicit Innago\.Shared\.Search\.PropertySearchExpressions\.AndSearchExpression\<T\>\(Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<T\>\[\]\)') | Implicitly converts an array of [ComparableSearchCriteria&lt;TMember&gt;](../../TypeSearchExpressions/ComparableSearchCriteria_TMember_/index.md 'Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<TMember\>') to an |
