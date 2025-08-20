#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SortOrder](../index.md 'Innago\.Shared\.Search\.SortOrder')

## SortOrderDirective\<TProperty\> Class

The sort order directive\.

```csharp
public class SortOrderDirective<TProperty> : Innago.Shared.Search.SortOrder.ISortOrderDirective
```
#### Type parameters

<a name='Innago.Shared.Search.SortOrder.SortOrderDirective_TProperty_.TProperty'></a>

`TProperty`

The type of the property\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; SortOrderDirective\<TProperty\>

Implements [ISortOrderDirective](../ISortOrderDirective/index.md 'Innago\.Shared\.Search\.SortOrder\.ISortOrderDirective')

| Properties | |
| :--- | :--- |
| [Direction](Direction.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderDirective\<TProperty\>\.Direction') | Gets or sets the Direction\. |

| Methods | |
| :--- | :--- |
| [Apply&lt;TSource&gt;\(IQueryable&lt;TSource&gt;, string\)](Apply_TSource_(IQueryable_TSource_,string).md 'Innago\.Shared\.Search\.SortOrder\.SortOrderDirective\<TProperty\>\.Apply\<TSource\>\(System\.Linq\.IQueryable\<TSource\>, string\)') | Applies the sort order directive to the queryable\. |

| Operators | |
| :--- | :--- |
| [implicit operator SortOrderDirective&lt;TProperty&gt;\(SortOrderDirection\)](implicitoperatorSortOrderDirective_TProperty_(SortOrderDirection).md 'Innago\.Shared\.Search\.SortOrder\.SortOrderDirective\<TProperty\>\.op\_Implicit Innago\.Shared\.Search\.SortOrder\.SortOrderDirective\<TProperty\>\(Innago\.Shared\.Search\.SortOrder\.SortOrderDirection\)') | Implicitly converts a [SortOrderDirection](../SortOrderDirection/index.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderDirection') to a [SortOrderDirective&lt;TProperty&gt;](index.md 'Innago\.Shared\.Search\.SortOrder\.SortOrderDirective\<TProperty\>')\. |
