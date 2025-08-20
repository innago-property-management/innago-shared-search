namespace UnitTests.Search.JsonConverters;

using System.Text.Json;

using Innago.Shared.Search.JsonConverters;
using Innago.Shared.Search.SearchCriteria;

[UnitTest(nameof(ComparableSearchExpressionJsonConverter))]
public class ComparableSearchExpressionJsonConverterTests
{
    [Fact]
    public void ItShouldDeserializeCorrectly()
    {
        const string json = "{\"EqualTo\":\"a\"}";

        var actual = JsonSerializer.Deserialize<ValueSearchCriteria<string>>(json)!;

        actual.EqualTo!.Value.Should().Be("a");
    }

    [Fact]
    public void ItShouldDeserializeLowercaseCorrectly()
    {
        const string json = "{\"equalTo\":\"a\"}";

        var actual = JsonSerializer.Deserialize<ValueSearchCriteria<string>>(json)!;

        actual.EqualTo!.Value.Should().Be("a");
    }

    [Fact]
    public void ItShouldSerializeCorrectly()
    {
        var searchCriteria = new ValueSearchCriteria<decimal>
        {
            NotEqualTo = 1.0m,
        };

        string json = JsonSerializer.Serialize(searchCriteria);

        json.Should().Be("{\"NotEqualTo\":1.0}");
    }
}
