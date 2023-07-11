#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

using System.Text.Json.Serialization;

using JetBrains.Annotations;

using Taazaa.Shared.DevKit.Framework.Search.JsonConverters;
using Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

/// <summary>
///     Represents a search criteria that can be used to search for a comparable value.
/// </summary>
[PublicAPI]
[JsonConverter(typeof(BooleanSearchCriteriaJsonConverter))]
public class BooleanSearchCriteria : ComparableSearchCriteria<bool>
{
    private SearchValue<bool>? value;

    /// <summary>
    ///     Gets or sets the value to search for.
    /// </summary>
    public SearchValue<bool>? Value
    {
        get => this.value;
        set
        {
            this.value = value;

            if (this.value is not null)
            {
                this.EqualToSearchExpression = this.value;
            }
        }
    }

    /// <summary>
    ///     Implicitly converts a <see cref="bool" /> to a <see cref="BooleanSearchCriteria" />.
    /// </summary>
    /// <param name="value">
    ///     The value to convert.
    /// </param>
    /// <returns>
    ///     A <see cref="BooleanSearchCriteria" /> that represents the converted <see cref="bool" />.
    /// </returns>
    public static implicit operator BooleanSearchCriteria(bool value)
    {
        return new BooleanSearchCriteria { Value = value };
    }
}