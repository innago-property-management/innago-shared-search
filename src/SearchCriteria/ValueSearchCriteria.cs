#nullable enable

namespace Innago.Shared.Search.SearchCriteria;

using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

using JetBrains.Annotations;

using JsonConverters;

using TypeSearchExpressions;

/// <summary>
///     Represents a search criteria that can be used to search for a comparable value.
/// </summary>
/// <typeparam name="TMember">
///     The type of the member to search for.
/// </typeparam>
[PublicAPI]
[JsonConverter(typeof(ComparableSearchExpressionJsonConverter))]
public class ValueSearchCriteria<TMember> : ComparableSearchCriteria<TMember>, IComparableSearchCriteria<TMember>
{
    private IEnumerable<ValueSearchCriteria<TMember>>? and;
    private SearchValue<TMember>? equalTo;
    private SearchValue<TMember>? greaterThan;
    private SearchValue<TMember>? greaterThanOrEqualTo;
    private SearchValues<TMember>? @in;
    private SearchValue<TMember>? lessThan;
    private SearchValue<TMember>? lessThanOrEqualTo;
    private SearchValue<TMember>? notEqualTo;
    private SearchValues<TMember>? notIn;
    private IEnumerable<ValueSearchCriteria<TMember>>? or;

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? EqualTo
    {
        get => this.equalTo;
        set
        {
            this.equalTo = value;

            if (this.equalTo is not null)
            {
                this.EqualToSearchExpression = this.equalTo.Value;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? NotEqualTo
    {
        get => this.notEqualTo;
        set
        {
            this.notEqualTo = value;

            if (this.notEqualTo is not null)
            {
                this.NotEqualToSearchExpression = this.notEqualTo.Value;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? GreaterThan
    {
        get => this.greaterThan;
        set
        {
            this.greaterThan = value;

            if (this.greaterThan is not null)
            {
                this.GreaterThanSearchExpression = this.greaterThan;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? GreaterThanOrEqualTo
    {
        get => this.greaterThanOrEqualTo;
        set
        {
            this.greaterThanOrEqualTo = value;

            if (this.greaterThanOrEqualTo is not null)
            {
                this.GreaterThanOrEqualToSearchExpression = this.greaterThanOrEqualTo;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? LessThan
    {
        get => this.lessThan;
        set
        {
            this.lessThan = value;

            if (this.lessThan is not null)
            {
                this.LessThanSearchExpression = this.lessThan;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<TMember>? LessThanOrEqualTo
    {
        get => this.lessThanOrEqualTo;
        set
        {
            this.lessThanOrEqualTo = value;

            if (this.lessThanOrEqualTo is not null)
            {
                this.LessThanOrEqualToSearchExpression = this.lessThanOrEqualTo;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValues<TMember>? In
    {
        get => this.@in;

        set
        {
            this.@in = value;

            if (this.@in is not null)
            {
                this.InSearchExpression = this.@in;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValues<TMember>? NotIn
    {
        get => this.notIn;

        set
        {
            this.notIn = value;

            if (this.notIn is not null)
            {
                this.NotInSearchExpression = this.notIn;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public IEnumerable<ValueSearchCriteria<TMember>>? And
    {
        get => this.and;
        set
        {
            this.and = value?.ToList();

            if (this.and?.Any() == true)
            {
                this.AndSearchExpression = this.and.ToArray();
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public IEnumerable<ValueSearchCriteria<TMember>>? Or
    {
        get => this.or;

        set
        {
            this.or = value?.ToList();

            if (this.or?.Any() == true)
            {
                this.OrSearchExpression = this.or.ToArray();
            }
        }
    }
}