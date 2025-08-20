#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SortOrder](../index.md 'Innago\.Shared\.Search\.SortOrder').[SortOrderBase&lt;TSource&gt;](index.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<TSource\>')

## SortOrderBase\<TSource\>\.Apply\(IQueryable\<TSource\>\) Method

Applies the sort order to the queryable\.

```csharp
public System.Linq.IOrderedQueryable<TSource> Apply(System.Linq.IQueryable<TSource> queryable);
```
#### Parameters

<a name='Innago.Shared.Search.SortOrder.SortOrderBase_TSource_.Apply(System.Linq.IQueryable_TSource_).queryable'></a>

`queryable` [System\.Linq\.IQueryable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')[TSource](index.md#Innago.Shared.Search.SortOrder.SortOrderBase_TSource_.TSource 'Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<TSource\>\.TSource')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')

The queryable to apply the sort order to\.

#### Returns
[System\.Linq\.IOrderedQueryable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iorderedqueryable-1 'System\.Linq\.IOrderedQueryable\`1')[TSource](index.md#Innago.Shared.Search.SortOrder.SortOrderBase_TSource_.TSource 'Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<TSource\>\.TSource')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iorderedqueryable-1 'System\.Linq\.IOrderedQueryable\`1')  
The queryable with the sort order applied\.