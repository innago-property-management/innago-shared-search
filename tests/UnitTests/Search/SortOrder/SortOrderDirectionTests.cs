namespace UnitTests.Search.SortOrder;

using Innago.Shared.Search.SortOrder;

[UnitTest(nameof(SortOrderDirection))]
public class SortOrderDirectionTests
{
    public static TheoryData<SortOrderDirection, int> TheoryData
    {
        get
        {
            var data = new TheoryData<SortOrderDirection, int>
            {
                { SortOrderDirection.Ascending, 0 },
                { SortOrderDirection.Descending, 1 },
            };

            return data;
        }
    }

    [Theory]
    [MemberData(nameof(TheoryData))]
    public void ItShouldHaveExpectedValues(SortOrderDirection direction, int expectedValue)
    {
        ((int)direction).Should().Be(expectedValue);
    }
}