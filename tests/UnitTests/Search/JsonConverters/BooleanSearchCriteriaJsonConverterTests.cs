namespace UnitTests.Search.JsonConverters;

using System.Text.Json;

using Innago.Shared.Search.JsonConverters;
using Innago.Shared.Search.SearchCriteria;

[UnitTest(nameof(BooleanSearchCriteria))]
public class BooleanSearchCriteriaJsonConverterTests
{
    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void ItShouldDeserializeCorrectly(bool value)
    {
        var json = $"{value.ToString().ToLower()}";

        var actual = JsonSerializer.Deserialize<BooleanSearchCriteria>(json);

        actual!.Value!.Value.Should().Be(value);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void ItShouldSerializeCorrectly(bool value)
    {
        var expected = $"{value.ToString().ToLower()}";

        BooleanSearchCriteria criteria = value;

        string actual = JsonSerializer.Serialize(criteria);

        actual.Should().Be(expected);
    }
}

[UnitTest(nameof(SearchValueJsonConverter))]
public class SearchValueJsonConverterTests
{
    [Fact]
    public void ItShouldDeserializeCorrectly()
    {
        const string abc = "abc";
        const string json = $"\"{abc}\"";

        var actual = JsonSerializer.Deserialize<SearchValue<string>>(json);

        actual!.Value.Should().Be(abc);
    }

    [Fact]
    public void ItShouldSerializeCorrectly()
    {
        SearchValue<int> searchValue = 1;
        string json = JsonSerializer.Serialize(searchValue);

        json.Should().Be("1");
    }
}
