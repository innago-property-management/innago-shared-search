namespace UnitTests.Search.JsonConverters;

using System.Text.Json;
using System.Text.Json.Serialization;

using Innago.Shared.Search.JsonConverters;
using Innago.Shared.Search.SortOrder;

[UnitTest(nameof(SortOrderDirectiveJsonConverter))]
public class SortOrderDirectiveJsonConverterTests
{
    private SortOrderDirectiveJsonConverter Target { get; } = new();

    [Fact]
    public void ItShouldBeAbleToConvertSortOrderDirective()
    {
        this.Target.CanConvert(typeof(SortOrderDirective<>)).Should().BeTrue();
    }

    [Theory]
    [InlineData("\"ascending\"")]
    [InlineData("\"Ascending\"")]
    [InlineData("\"ASCENDING\"")]
    [InlineData("\"descending\"")]
    [InlineData("\"Descending\"")]
    [InlineData("\"DESCENDING\"")]
    public void ItShouldDeSerializeCorrectly(string json)
    {
        var direction = Enum.Parse<SortOrderDirection>(json.Replace("\"", string.Empty), true);
        var expected = new SortOrderDirective<int> { Direction = direction };

        var actual = JsonSerializer.Deserialize<SortOrderDirective<int>>(json);

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ItShouldExtendJsonConverterFactory()
    {
        this.Target.GetType().Should().BeDerivedFrom<JsonConverterFactory>();
    }

    [Theory]
    [InlineData(SortOrderDirection.Ascending)]
    [InlineData(SortOrderDirection.Descending)]
    public void ItShouldSerializeCorrectly(SortOrderDirection direction)
    {
        var expected = $"\"{direction}\"";

        SortOrderDirective<int> directive = direction;

        string actual = JsonSerializer.Serialize(directive);

        actual.Should().Be(expected);
    }
}
