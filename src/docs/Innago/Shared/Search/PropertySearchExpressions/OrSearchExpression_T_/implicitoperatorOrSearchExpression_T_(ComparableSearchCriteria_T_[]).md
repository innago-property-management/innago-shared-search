#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.PropertySearchExpressions](../index.md 'Innago\.Shared\.Search\.PropertySearchExpressions').[OrSearchExpression&lt;T&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>')

## OrSearchExpression\<T\>\.implicit operator OrSearchExpression\<T\>\(ComparableSearchCriteria\<T\>\[\]\) Operator

Implicitly converts an array of [ComparableSearchCriteria&lt;TMember&gt;](../../TypeSearchExpressions/ComparableSearchCriteria_TMember_/index.md 'Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<TMember\>') to an
[OrSearchExpression&lt;T&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>')\.

```csharp
public static Innago.Shared.Search.PropertySearchExpressions.OrSearchExpression<T> implicit operator Innago.Shared.Search.PropertySearchExpressions.OrSearchExpression<T>(Innago.Shared.Search.TypeSearchExpressions.ComparableSearchCriteria<T>[] clauses);
```
#### Parameters

<a name='Innago.Shared.Search.PropertySearchExpressions.OrSearchExpression_T_.op_ImplicitInnago.Shared.Search.PropertySearchExpressions.OrSearchExpression_T_(Innago.Shared.Search.TypeSearchExpressions.ComparableSearchCriteria_T_[]).clauses'></a>

`clauses` [Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria&lt;](../../TypeSearchExpressions/ComparableSearchCriteria_TMember_/index.md 'Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<TMember\>')[T](index.md#Innago.Shared.Search.PropertySearchExpressions.OrSearchExpression_T_.T 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>\.T')[&gt;](../../TypeSearchExpressions/ComparableSearchCriteria_TMember_/index.md 'Innago\.Shared\.Search\.TypeSearchExpressions\.ComparableSearchCriteria\<TMember\>')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

The clauses to convert\.

#### Returns
[Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression&lt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>')[T](index.md#Innago.Shared.Search.PropertySearchExpressions.OrSearchExpression_T_.T 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>\.T')[&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>')  
The [OrSearchExpression&lt;T&gt;](index.md 'Innago\.Shared\.Search\.PropertySearchExpressions\.OrSearchExpression\<T\>')\.