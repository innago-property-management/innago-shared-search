#nullable enable
using JetBrains.Annotations;
using Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

/// <summary>
///     The <see cref="StringSearchCriteria" /> class is used to specify search criteria for a <see cref="string" />
///     property.
/// </summary>
[PublicAPI]
public class StringSearchCriteria : StringSearchExpression
{
    private SearchValue<string>? contains;
    private SearchValue<string>? doesNotContain;
    private SearchValue<string>? doesNotEndWith;
    private SearchValue<string>? doesNotStartWith;
    private SearchValue<string>? endsWith;
    private SearchValue<string>? startsWith;

    /// <summary>
    ///     Gets or sets the value to search for in the <see cref="string" /> property.
    /// </summary>
    public SearchValue<string>? Contains
    {
        get => this.contains;

        set
        {
            this.contains = value;

            if (this.contains is not null)
            {
                this.StringContainsExpression = this.contains;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for in the <see cref="string" /> property.
    /// </summary>
    public SearchValue<string>? DoesNotContain
    {
        get => this.doesNotContain;

        set
        {
            this.doesNotContain = value;

            if (this.doesNotContain is not null)
            {
                this.StringDoesNotContainExpression = this.doesNotContain;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for in the <see cref="string" /> property.
    /// </summary>
    public SearchValue<string>? DoesNotEndWith
    {
        get => this.doesNotEndWith;

        set
        {
            this.doesNotEndWith = value;

            if (this.doesNotEndWith is not null)
            {
                this.StringDoesNotEndWithExpression = this.doesNotEndWith;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for in the <see cref="string" /> property.
    /// </summary>
    public SearchValue<string>? DoesNotStartWith
    {
        get => this.doesNotStartWith;

        set
        {
            this.doesNotStartWith = value;

            if (this.doesNotStartWith is not null)
            {
                this.StringDoesNotStartWithExpression = this.doesNotStartWith;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for in the <see cref="string" /> property.
    /// </summary>
    public SearchValue<string>? EndsWith
    {
        get => this.endsWith;

        set
        {
            this.endsWith = value;

            if (this.endsWith is not null)
            {
                this.StringEndsWithExpression = this.endsWith;
            }
        }
    }

    /// <summary>
    ///     Gets or sets the value to search for in the <see cref="string" /> property.
    /// </summary>
    public SearchValue<string>? StartsWith
    {
        get => this.startsWith;

        set
        {
            this.startsWith = value;

            if (this.startsWith is not null)
            {
                this.StringStartsWithExpression = this.startsWith;
            }
        }
    }
}