# Taazaa.Shared.DevKit.Framework.Search assembly

## Taazaa.Shared.DevKit.Framework.Search namespace

| public type | description |
| --- | --- |
| record [SearchValue&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search/SearchValue-1.md) | Represents a value that can be used in a search. |
| record [SearchValues&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search/SearchValues-1.md) | Represents a set of values that can be used in a search. |

## Taazaa.Shared.DevKit.Framework.Search.JsonConverters namespace

| public type | description |
| --- | --- |
| class [SortOrderDirectiveJsonConverter](./Taazaa.Shared.DevKit.Framework.Search.JsonConverters/SortOrderDirectiveJsonConverter.md) | The sort order directive json converter. |

## Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions namespace

| public type | description |
| --- | --- |
| class [AndSearchExpression&lt;T&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/AndSearchExpression-1.md) | Represents a search expression that is a logical AND of other search expressions. |
| class [EqualToSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/EqualToSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [GreaterThanOrEqualToSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/GreaterThanOrEqualToSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [GreaterThanSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/GreaterThanSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [InSearchExpression&lt;TSource&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/InSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| interface [ISearchExpression](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/ISearchExpression.md) | Defines a search expression. |
| class [LessThanOrEqualToSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/LessThanOrEqualToSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [LessThanSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/LessThanSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [NotEqualToSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/NotEqualToSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [NotInSearchExpression&lt;TSource&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/NotInSearchExpression-1.md) | Represents a search expression that compares a property to a value. |
| class [OrSearchExpression&lt;T&gt;](./Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions/OrSearchExpression-1.md) | Represents a search expression that is a logical OR of other search expressions. |

## Taazaa.Shared.DevKit.Framework.Search.SearchCriteria namespace

| public type | description |
| --- | --- |
| class [BooleanSearchCriteria](./Taazaa.Shared.DevKit.Framework.Search.SearchCriteria/BooleanSearchCriteria.md) | Represents a search criteria that can be used to search for a comparable value. |
| interface [IComparableSearchCriteria&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.SearchCriteria/IComparableSearchCriteria-1.md) | Represents a search criteria that can be used to search for a comparable value. |

## Taazaa.Shared.DevKit.Framework.Search.SortOrder namespace

| public type | description |
| --- | --- |
| interface [ISortOrderDirective](./Taazaa.Shared.DevKit.Framework.Search.SortOrder/ISortOrderDirective.md) | The interface for a sort order directive. |
| static class [SortingQueryableExtensions](./Taazaa.Shared.DevKit.Framework.Search.SortOrder/SortingQueryableExtensions.md) | The sorting queryable extensions. |
| abstract class [SortOrderBase&lt;TSource&gt;](./Taazaa.Shared.DevKit.Framework.Search.SortOrder/SortOrderBase-1.md) | Base class for sort order classes. |
| enum [SortOrderDirection](./Taazaa.Shared.DevKit.Framework.Search.SortOrder/SortOrderDirection.md) | The direction of the sort order. |
| class [SortOrderDirective&lt;TProperty&gt;](./Taazaa.Shared.DevKit.Framework.Search.SortOrder/SortOrderDirective-1.md) | The sort order directive. |

## Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions namespace

| public type | description |
| --- | --- |
| class [ComparableSearchExpression&lt;TMember&gt;](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/ComparableSearchExpression-1.md) | A search expression that combines multiple [`ComparableSearchExpression`](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/ComparableSearchExpression-1.md)s into a single |
| class [StringContainsSearchExpression](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/StringContainsSearchExpression.md) | Represents a search expression that checks if a string contains a value. |
| class [StringDoesNotContainSearchExpression](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/StringDoesNotContainSearchExpression.md) | Represents a search expression that checks if a string does not contain a value. |
| class [StringDoesNotEndWithSearchExpression](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/StringDoesNotEndWithSearchExpression.md) | Represents a search expression that checks if a string DoesNotEndWith a value. |
| class [StringDoesNotStartWithSearchExpression](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/StringDoesNotStartWithSearchExpression.md) | Represents a search expression that checks if a string does not StartsWith a value. |
| class [StringEndsWithSearchExpression](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/StringEndsWithSearchExpression.md) | Represents a search expression that checks if a string EndsWith a value. |
| class [StringStartsWithSearchExpression](./Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions/StringStartsWithSearchExpression.md) | Represents a search expression that checks if a string StartsWith a value. |

<!-- DO NOT EDIT: generated by xmldocmd for Taazaa.Shared.DevKit.Framework.Search.dll -->
