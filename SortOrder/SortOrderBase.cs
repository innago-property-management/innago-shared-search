#nullable enable

namespace Taazaa.Shared.DevKit.Framework.Search.SortOrder;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

/// <summary>
///     Base class for sort order classes.
/// </summary>
/// <typeparam name="TSource"></typeparam>
public abstract class SortOrderBase<TSource> : IValidatableObject
{
    /// <inheritdoc />
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var results = new List<ValidationResult>();
        int? count = (validationContext.ObjectInstance as SortOrderBase<TSource>)?.GetNonNullSortOrderDirectives().Count();

        if (count > 1)
        {
            results.Add(new ValidationResult($"There should only be 0 or 1 SortOrderDirection props with a value. Found {count}"));
        }

        return results;
    }

    /// <summary>
    ///     Gets the default sort order directive.
    /// </summary>
    protected abstract (string Name, ISortOrderDirective Directive) DefaultSort { get; }

    private IEnumerable<(string Name, ISortOrderDirective Directive)> GetNonNullSortOrderDirectives()
    {
        IEnumerable<(string Name, ISortOrderDirective Directive)> retVal = from info in this.GetType().GetProperties()
            where typeof(ISortOrderDirective).IsAssignableFrom(info.PropertyType)
            let sortOrderDirective = info.GetValue(this) as ISortOrderDirective
            where sortOrderDirective != null
            select (info.Name, sortOrderDirective);

        return retVal;
    }

    /// <summary>
    ///     Applies the sort order to the queryable. 
    /// </summary>
    /// <param name="queryable">
    ///    The queryable to apply the sort order to.
    /// </param>
    /// <returns>
    ///   The queryable with the sort order applied.
    /// </returns>
    public IOrderedQueryable<TSource> Apply(IQueryable<TSource> queryable)
    {
        Validator.ValidateObject(this, new ValidationContext(this), true);

        List<(string Name, ISortOrderDirective Directive)> directives = this.GetNonNullSortOrderDirectives().ToList();

        (string? name, ISortOrderDirective? directive) = directives.Any() ? directives.Single() : this.DefaultSort;

        return directive.Apply(queryable, name);
    }
}