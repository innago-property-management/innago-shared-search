#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

using JetBrains.Annotations;

using Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

/// <summary>
///    The <see cref="StringSearchCriteria" /> class is used to specify search criteria for a <see cref="string" /> property.
/// </summary>
[PublicAPI]
public class StringSearchCriteria : StringSearchExpression
{
    private SearchValue<string>? contains;
    private SearchValue<string>? endsWith;
    private SearchValue<string>? startsWith;

    /// <summary>
    ///   Gets or sets the value to search for in the <see cref="string" /> property.
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
    ///  Gets or sets the value to search for in the <see cref="string" /> property.
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
    /// Gets or sets the value to search for in the <see cref="string" /> property.
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