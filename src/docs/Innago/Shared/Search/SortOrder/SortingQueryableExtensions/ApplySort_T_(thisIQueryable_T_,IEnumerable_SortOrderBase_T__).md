#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SortOrder](../index.md 'Innago\.Shared\.Search\.SortOrder').[SortingQueryableExtensions](index.md 'Innago\.Shared\.Search\.SortOrder\.SortingQueryableExtensions')

## SortingQueryableExtensions\.ApplySort\<T\>\(this IQueryable\<T\>, IEnumerable\<SortOrderBase\<T\>\>\) Method

Applies the sort\.

```csharp
public static System.Linq.IQueryable<T> ApplySort<T>(this System.Linq.IQueryable<T> queryable, System.Collections.Generic.IEnumerable<Innago.Shared.Search.SortOrder.SortOrderBase<T>> sortOrders);
```
#### Type parameters

<a name='Innago.Shared.Search.SortOrder.SortingQueryableExtensions.ApplySort_T_(thisSystem.Linq.IQueryable_T_,System.Collections.Generic.IEnumerable_Innago.Shared.Search.SortOrder.SortOrderBase_T__).T'></a>

`T`

The type of the queryable\.
#### Parameters

<a name='Innago.Shared.Search.SortOrder.SortingQueryableExtensions.ApplySort_T_(thisSystem.Linq.IQueryable_T_,System.Collections.Generic.IEnumerable_Innago.Shared.Search.SortOrder.SortOrderBase_T__).queryable'></a>

`queryable` [System\.Linq\.IQueryable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')[T](ApplySort_T_(thisIQueryable_T_,IEnumerable_SortOrderBase_T__).md#Innago.Shared.Search.SortOrder.SortingQueryableExtensions.ApplySort_T_(thisSystem.Linq.IQueryable_T_,System.Collections.Generic.IEnumerable_Innago.Shared.Search.SortOrder.SortOrderBase_T__).T 'Innago\.Shared\.Search\.SortOrder\.SortingQueryableExtensions\.ApplySort\<T\>\(this System\.Linq\.IQueryable\<T\>, System\.Collections\.Generic\.IEnumerable\<Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<T\>\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')

The queryable to sort\.

<a name='Innago.Shared.Search.SortOrder.SortingQueryableExtensions.ApplySort_T_(thisSystem.Linq.IQueryable_T_,System.Collections.Generic.IEnumerable_Innago.Shared.Search.SortOrder.SortOrderBase_T__).sortOrders'></a>

`sortOrders` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[Innago\.Shared\.Search\.SortOrder\.SortOrderBase&lt;](../SortOrderBase_TSource_/index.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<TSource\>')[T](ApplySort_T_(thisIQueryable_T_,IEnumerable_SortOrderBase_T__).md#Innago.Shared.Search.SortOrder.SortingQueryableExtensions.ApplySort_T_(thisSystem.Linq.IQueryable_T_,System.Collections.Generic.IEnumerable_Innago.Shared.Search.SortOrder.SortOrderBase_T__).T 'Innago\.Shared\.Search\.SortOrder\.SortingQueryableExtensions\.ApplySort\<T\>\(this System\.Linq\.IQueryable\<T\>, System\.Collections\.Generic\.IEnumerable\<Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<T\>\>\)\.T')[&gt;](../SortOrderBase_TSource_/index.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<TSource\>')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

The sort orders\.

#### Returns
[System\.Linq\.IQueryable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')[T](ApplySort_T_(thisIQueryable_T_,IEnumerable_SortOrderBase_T__).md#Innago.Shared.Search.SortOrder.SortingQueryableExtensions.ApplySort_T_(thisSystem.Linq.IQueryable_T_,System.Collections.Generic.IEnumerable_Innago.Shared.Search.SortOrder.SortOrderBase_T__).T 'Innago\.Shared\.Search\.SortOrder\.SortingQueryableExtensions\.ApplySort\<T\>\(this System\.Linq\.IQueryable\<T\>, System\.Collections\.Generic\.IEnumerable\<Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<T\>\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')  
The [System\.Linq\.IQueryable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1') with the [SortOrderBase&lt;TSource&gt;](../SortOrderBase_TSource_/index.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderBase\<TSource\>') entries applied in order\.

### Example

```csharp
IQueryable<Dummy> data = new[]
{
  // ...
}

var sortOrders = new[]
{
  new DummySortOrder { Name = SortOrderDirection.Ascending },
  new DummySortOrder { Id = SortOrderDirection.Ascending },
};

var result = data.ApplySort(sortOrders);
```