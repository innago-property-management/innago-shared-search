#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SortOrder](../index.md 'Innago\.Shared\.Search\.SortOrder').[ISortOrderDirective](index.md 'Innago\.Shared\.Search\.SortOrder\.ISortOrderDirective')

## ISortOrderDirective\.Apply\<TSource\>\(IQueryable\<TSource\>, string\) Method

Applies the sort order directive to the queryable\.

```csharp
System.Linq.IOrderedQueryable<TSource> Apply<TSource>(System.Linq.IQueryable<TSource> queryable, string propertyName);
```
#### Type parameters

<a name='Innago.Shared.Search.SortOrder.ISortOrderDirective.Apply_TSource_(System.Linq.IQueryable_TSource_,string).TSource'></a>

`TSource`

The type of the source\.
#### Parameters

<a name='Innago.Shared.Search.SortOrder.ISortOrderDirective.Apply_TSource_(System.Linq.IQueryable_TSource_,string).queryable'></a>

`queryable` [System\.Linq\.IQueryable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')[TSource](Apply_TSource_(IQueryable_TSource_,string).md#Innago.Shared.Search.SortOrder.ISortOrderDirective.Apply_TSource_(System.Linq.IQueryable_TSource_,string).TSource 'Innago\.Shared\.Search\.SortOrder\.ISortOrderDirective\.Apply\<TSource\>\(System\.Linq\.IQueryable\<TSource\>, string\)\.TSource')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iqueryable-1 'System\.Linq\.IQueryable\`1')

The queryable to apply the sort order directive to\.

<a name='Innago.Shared.Search.SortOrder.ISortOrderDirective.Apply_TSource_(System.Linq.IQueryable_TSource_,string).propertyName'></a>

`propertyName` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The name of the property to apply the sort order directive to\.

#### Returns
[System\.Linq\.IOrderedQueryable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iorderedqueryable-1 'System\.Linq\.IOrderedQueryable\`1')[TSource](Apply_TSource_(IQueryable_TSource_,string).md#Innago.Shared.Search.SortOrder.ISortOrderDirective.Apply_TSource_(System.Linq.IQueryable_TSource_,string).TSource 'Innago\.Shared\.Search\.SortOrder\.ISortOrderDirective\.Apply\<TSource\>\(System\.Linq\.IQueryable\<TSource\>, string\)\.TSource')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.linq.iorderedqueryable-1 'System\.Linq\.IOrderedQueryable\`1')  
The queryable with the sort order directive applied\.