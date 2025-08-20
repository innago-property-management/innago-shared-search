#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SearchCriteria](../index.md 'Innago\.Shared\.Search\.SearchCriteria').[SearchCriteriaBase&lt;TSource&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase\<TSource\>')

## SearchCriteriaBase\<TSource\>\.implicit operator Expression\<Func\<TSource,bool\>\>\(SearchCriteriaBase\<TSource\>\) Operator

Performs an implicit conversion from [SearchCriteriaBase&lt;TSource&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase\<TSource\>') to [System\.Linq\.Expressions\.Expression&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1 'System\.Linq\.Expressions\.Expression\`1')\.

```csharp
public static System.Linq.Expressions.Expression<System.Func<TSource,bool>> implicit operator System.Linq.Expressions.Expression<System.Func<TSource,bool>>(Innago.Shared.Search.SearchCriteria.SearchCriteriaBase<TSource> searchCriteria);
```
#### Parameters

<a name='Innago.Shared.Search.SearchCriteria.SearchCriteriaBase_TSource_.op_ImplicitSystem.Linq.Expressions.Expression_System.Func_TSource,bool__(Innago.Shared.Search.SearchCriteria.SearchCriteriaBase_TSource_).searchCriteria'></a>

`searchCriteria` [Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase&lt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase\<TSource\>')[TSource](index.md#Innago.Shared.Search.SearchCriteria.SearchCriteriaBase_TSource_.TSource 'Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase\<TSource\>\.TSource')[&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase\<TSource\>')

The search criteria\.

#### Returns
[System\.Linq\.Expressions\.Expression&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1 'System\.Linq\.Expressions\.Expression\`1')[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](index.md#Innago.Shared.Search.SearchCriteria.SearchCriteriaBase_TSource_.TSource 'Innago\.Shared\.Search\.SearchCriteria\.SearchCriteriaBase\<TSource\>\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1 'System\.Linq\.Expressions\.Expression\`1')  
The result of the conversion\.