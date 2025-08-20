#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SearchCriteria](../index.md 'Innago\.Shared\.Search\.SearchCriteria')

## AndSearchCriteria\<TSearchCriteria,TSource\> Class

Logical AND of criteria

```csharp
public class AndSearchCriteria<TSearchCriteria,TSource>
    where TSearchCriteria : Innago.Shared.Search.SearchCriteria.SearchCriteriaBase<TSource>
```
#### Type parameters

<a name='Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_.TSearchCriteria'></a>

`TSearchCriteria`

The type of the search criteria\.

<a name='Innago.Shared.Search.SearchCriteria.AndSearchCriteria_TSearchCriteria,TSource_.TSource'></a>

`TSource`

The type of the source\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; AndSearchCriteria\<TSearchCriteria,TSource\>

| Operators | |
| :--- | :--- |
| [implicit operator AndSearchCriteria&lt;TSearchCriteria,TSource&gt;\(TSearchCriteria\[\]\)](implicitoperatorAndSearchCriteria_TSearchCriteria,TSource_(TSearchCriteria[]).md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\.op\_Implicit Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\(TSearchCriteria\[\]\)') | Implicitly converts |
| [implicit operator Expression&lt;Func&lt;TSource,bool&gt;&gt;\(AndSearchCriteria&lt;TSearchCriteria,TSource&gt;\)](implicitoperatorExpression_Func_TSource,bool__(AndSearchCriteria_TSearchCriteria,TSource_).md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\.op\_Implicit System\.Linq\.Expressions\.Expression\<System\.Func\<TSource,bool\>\>\(Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>\)') | Implicitly converts an [AndSearchCriteria&lt;TSearchCriteria,TSource&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.AndSearchCriteria\<TSearchCriteria,TSource\>') to an expression for use in a where clause\. |
