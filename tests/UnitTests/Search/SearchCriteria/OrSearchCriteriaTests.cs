namespace UnitTests.Search.SearchCriteria;

using System.Text.Json;

using Innago.Shared.Search.SearchCriteria;

using SortOrder;

using Xunit.Abstractions;

[UnitTest(nameof(OrSearchCriteria<DummySearchCriteria, Dummy>))]
public class OrSearchCriteriaTests
{
    public OrSearchCriteriaTests(ITestOutputHelper outputHelper)
    {
        this.OutputHelper = outputHelper;
    }

    private ITestOutputHelper OutputHelper { get; }

    [Fact]
    public void EmptyCriteriaShouldProduceCorrectExpression()
    {
        IQueryable<Dummy> data = new Dummy[]
        {
            new() { Id = 1, Name = "a" },
            new() { Id = 2, Name = "dada" },
            new() { Id = 3, Name = "bbb" },
        }.AsQueryable();

        OrSearchCriteria<DummySearchCriteria, Dummy> orSearchCriteria = Array.Empty<DummySearchCriteria>();

        IEnumerable<int> expected = data.Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(expected));

        IEnumerable<int> actual = data.Where(orSearchCriteria).Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ItShouldBeComposable()
    {
        Func<OrSearchCriteria<DummySearchCriteria, Dummy>> func = () =>
        {
            OrSearchCriteria<DummySearchCriteria, Dummy> searchCriteria = new[]
            {
                new DummySearchCriteria { Id = new ValueSearchCriteria<int> { NotEqualTo = 1 } },
                new DummySearchCriteria { Id = new ValueSearchCriteria<int> { NotEqualTo = 2 } },
            };

            return searchCriteria;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldProduceCorrectExpression()
    {
        IQueryable<Dummy> data = new Dummy[]
        {
            new() { Id = 1, Name = "a" },
            new() { Id = 2, Name = "dada" },
            new() { Id = 3, Name = "bbb" },
        }.AsQueryable();

        DummySearchCriteria searchCriteria0 = new()
        {
            Id = new ValueSearchCriteria<int>
            {
                NotEqualTo = 2,
            },
        };

        DummySearchCriteria searchCriteria1 = new()
        {
            Id = new ValueSearchCriteria<int>
            {
                GreaterThanOrEqualTo = 1,
            },
        };

        OrSearchCriteria<DummySearchCriteria, Dummy> orSearchCriteria = new[]
        {
            searchCriteria0,
            searchCriteria1,
        };

        IEnumerable<int> expected = data.Where(d => d.Id != 2 || d.Id >= 1).Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(expected));

        IEnumerable<int> actual = data.Where(orSearchCriteria).Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void NullCriteriaShouldProduceCorrectExpression()
    {
        IQueryable<Dummy> data = new Dummy[]
        {
            new() { Id = 1, Name = "a" },
            new() { Id = 2, Name = "dada" },
            new() { Id = 3, Name = "bbb" },
        }.AsQueryable();

        var orSearchCriteria = new OrSearchCriteria<DummySearchCriteria, Dummy>();

        IEnumerable<int> expected = data.Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(expected));

        IEnumerable<int> actual = data.Where(orSearchCriteria).Select(d => d.Id).ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().BeEquivalentTo(expected);
    }
}