#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.TypeSearchExpressions](../index.md 'Innago\.Shared\.Search\.TypeSearchExpressions')

## ComparableSearchCriteria\<TMember\> Class

A search expression that combines multiple [ComparableSearchCriteria&lt;TMember&gt;](index.md 'Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<TMember\>')s into a single

```csharp
public class ComparableSearchCriteria<TMember> : Innago.Shared.Search.PropertySearchExpressions.ISearchExpression
```
#### Type parameters

<a name='Innago.Shared.Search.TypeSearchExpressions.ComparableSearchCriteria_TMember_.TMember'></a>

`TMember`

The type of the property\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; ComparableSearchCriteria\<TMember\>

Derived  
&#8627; [BooleanSearchCriteria](../../SearchCriteria/BooleanSearchCriteria/index.md 'Innago\.Shared\.Search\.SearchCriteria\.BooleanSearchCriteria')  
&#8627; [ValueSearchCriteria&lt;TMember&gt;](../../SearchCriteria/ValueSearchCriteria_TMember_/index.md 'Innago\.Shared\.Search\.SearchCriteria\.ValueSearchCriteria\<TMember\>')

Implements [ISearchExpression](../../PropertySearchExpressions/ISearchExpression/index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.ISearchExpression')