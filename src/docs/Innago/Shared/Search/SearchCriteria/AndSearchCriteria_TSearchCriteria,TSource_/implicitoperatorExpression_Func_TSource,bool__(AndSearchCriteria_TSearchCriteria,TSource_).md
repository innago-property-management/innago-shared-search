#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SearchCriteria](../index.md 'Innago\.Shared\.Search\.SearchCriteria').[AndSearchCriteria&lt;TSearchCriteria,TSource&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>')

## AndSearchCriteria\<TSearchCriteria,TSource\>\.implicit operator Expression\<Func\<TSource,bool\>\>\(AndSearchCriteria\<TSearchCriteria,TSource\>\) Operator

Implicitly converts an [AndSearchCriteria&lt;TSearchCriteria,TSource&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>') to an expression for use in a
where clause\.

```csharp
public static System.Linq.Expressions.Expression<System.Func<TSource,bool>> implicit operator System.Linq.Expressions.Expression<System.Func<TSource,bool>>(Innago.Shared.Search.SearchCriteria.AndSearchCriteria<TSearchCriteria,TSource> searchCriteria);
```
#### Parameters

<a name='Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_.op_ImplicitSystem.Linq.Expressions.Expression_System.Func_TSource,bool__(Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_).searchCriteria'></a>

`searchCriteria` [Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria&lt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>')[TSearchCriteria](index.md#Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_.TSearchCriteria 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\.TSearchCriteria')[,](index.md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>')[TSource](index.md#Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_.TSource 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\.TSource')[&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>')

The search criteria\.

#### Returns
[System\.Linq\.Expressions\.Expression&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1 'System\.Linq\.Expressions\.Expression\`1')[System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[TSource](index.md#Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_.TSource 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\.TSource')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.expressions.expression-1 'System\.Linq\.Expressions\.Expression\`1')  
An expression\.