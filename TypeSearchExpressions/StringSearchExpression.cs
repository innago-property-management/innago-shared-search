#nullable enable
namespace Taazaa.Shared.DevKit.Framework.Search.TypeSearchExpressions;

using JetBrains.Annotations;

using Taazaa.Shared.DevKit.Framework.Search.PropertySearchExpressions;
using Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

/// <summary>
///     The <see cref="StringSearchExpression" /> class is used to specify search criteria for a <see cref="string" />
///     property.
/// </summary>
[PublicAPI]
public class StringSearchExpression : ValueSearchCriteria<string>
{
    internal StringContainsSearchExpression? StringContainsExpression { get; set; }
    internal StringDoesNotContainSearchExpression? StringDoesNotContainExpression { get; set; }
    internal StringDoesNotEndWithSearchExpression? StringDoesNotEndWithExpression { get; set; }
    internal StringDoesNotStartWithSearchExpression? StringDoesNotStartWithExpression { get; set; }
    internal StringEndsWithSearchExpression? StringEndsWithExpression { get; set; }
    internal StringStartsWithSearchExpression? StringStartsWithExpression { get; set; }
}