#### [Innago\.Shared\.Search](../../../../../index.md 'index')
### [Innago\.Shared\.Search\.SearchCriteria](../index.md 'Innago\.Shared\.Search\.SearchCriteria')

## OrSearchCriteria\<TSearchCriteria,TSource\> Class

Logical OR of criteria\.

```csharp
public class OrSearchCriteria<TSearchCriteria,TSource>
    where TSearchCriteria : Innago.Shared.Search.SearchCriteria.SearchCriteriaBase<TSource>
```
#### Type parameters

<a name='Innago.Shared.Search.SearchCriteria.OrSearchCriteria_TSearchCriteria,TSource_.TSearchCriteria'></a>

`TSearchCriteria`

The criteria type\.

<a name='Innago.Shared.Search.SearchCriteria.OrSearchCriteria_TSearchCriteria,TSource_.TSource'></a>

`TSource`

The source type\.

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') &#129106; OrSearchCriteria\<TSearchCriteria,TSource\>

| Operators | |
| :--- | :--- |
| [implicit operator OrSearchCriteria&lt;TSearchCriteria,TSource&gt;\(TSearchCriteria\[\]\)](implicitoperatorOrSearchCriteria_TSearchCriteria,TSource_(TSearchCriteria[]).md 'Innago\.Shared\.Search\.SearchCriteria\.OrSearchCriteria\<TSearchCriteria,TSource\>\.op\_Implicit Innago\.Shared\.Search\.SearchCriteria\.OrSearchCriteria\<TSearchCriteria,TSource\>\(TSearchCriteria\[\]\)') | Implicitly converts an array of criteria to an [OrSearchCriteria&lt;TSearchCriteria,TSource&gt;](index.md 'Innago\.Shared\.Search\.SearchCriteria\.OrSearchCriteria\<TSearchCriteria,TSource\>')\. |
| [implicit operator Expression&lt;Func&lt;TSource,bool&gt;&gt;\(OrSearchCriteria&lt;TSearchCriteria,TSource&gt;\)](implicitoperatorExpression_Func_TSource,bool__(OrSearchCriteria_TSearchCriteria,TSource_).md 'Innago\.Shared\.Search\.SearchCriteria\.OrSearchCriteria\<TSearchCriteria,TSource\>\.op\_Implicit System\.Linq\.Expressions\.Expression\<System\.Func\<TSource,bool\>\>\(Innago\.Shared\.Search\.SearchCriteria\.OrSearchCriteria\<TSearchCriteria,TSource\>\)') | Implicitly converts the criteria to an expression for use in a where clause\. |
