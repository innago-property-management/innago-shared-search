namespace UnitTests.Search.SortOrder;

using System.Text.Json;

using Innago.Shared.Search.SortOrder;

using Xunit.Abstractions;

[UnitTest(nameof(SortingQueryableExtensions.ApplySort))]
public class ApplySortTests
{
    public ApplySortTests(ITestOutputHelper outputHelper)
    {
        this.OutputHelper = outputHelper;
    }

    private ITestOutputHelper OutputHelper { get; }

    [Fact]
    public void ApplySortShouldApplyTheSortDirectivesInOrder()
    {
        IQueryable<Dummy> data = new[]
        {
            new Dummy { Id = 1, Name = "b" },
            new Dummy { Id = 91, Name = "a" },
            new Dummy { Id = 21, Name = "c" },
            new Dummy { Id = 81, Name = "b" },
            new Dummy { Id = 7, Name = "a" },
        }.AsQueryable();

        var sortOrders = new[]
        {
            new DummySortOrder { Name = SortOrderDirection.Ascending },
            new DummySortOrder { Id = SortOrderDirection.Ascending },
        };

        IEnumerable<int> expectedOrder = sortOrders[1].Apply(sortOrders[0].Apply(data)).Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine($"{nameof(expectedOrder)}:{JsonSerializer.Serialize(expectedOrder)}");

        IEnumerable<int> actualOrder = data.ApplySort(sortOrders).Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine($"{nameof(actualOrder)}:{JsonSerializer.Serialize(actualOrder)}");

        actualOrder.Should().BeEquivalentTo(expectedOrder, options => options.WithStrictOrdering());
    }
}