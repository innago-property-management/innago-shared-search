namespace UnitTests.Search.SearchCriteria;

using System.Diagnostics.CodeAnalysis;

using Innago.Shared.Search.SearchCriteria;
using Innago.Shared.Search.TypeSearchExpressions;

using SortOrder;

[UnitTest(nameof(SearchCriteriaBase<Dummy>))]
public class SearchCriteriaBaseTests
{
    [Fact]
    public void EmptyCriteriaShouldReturnAll()
    {
        IQueryable<Dummy> data = new Dummy[]
        {
            new() { Id = 1, Name = "a" },
            new() { Id = 2, Name = "dada" },
            new() { Id = 3, Name = "bbb" },
        }.AsQueryable();

        var criteria = new DummySearchCriteria();

        IEnumerable<int> expected = data.Select(d => d.Id).ToList();

        IEnumerable<int> actual = data.Where(criteria).Select(d => d.Id).ToList();

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ItShouldBeAbstract()
    {
        typeof(SearchCriteriaBase<>).IsAbstract.Should().BeTrue();
    }

    [Fact]
    public void ItShouldSetCorrectExpression()
    {
        IQueryable<Dummy> data = new Dummy[]
        {
            new() { Id = 1, Name = "a" },
            new() { Id = 2, Name = "dada" },
            new() { Id = 3, Name = "bbb" },
        }.AsQueryable();

        var criteria = new DummySearchCriteria
        {
            Id = new ValueSearchCriteria<int>
            {
                GreaterThanOrEqualTo = 2,
            },
            Name = new StringSearchCriteria
            {
                Contains = "a",
            },
        };

        IEnumerable<int> expected = data.Where(d => d.Id >= 2 && d.Name != null && d.Name.Contains('a')).Select(d => d.Id).ToList();

        IEnumerable<int> actual = data.Where(criteria).Select(d => d.Id).ToList();

        actual.Should().BeEquivalentTo(expected);
    }
}

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class DummySearchCriteria : SearchCriteriaBase<Dummy>
{
    public ComparableSearchCriteria<int>? Id { get; set; }
    public StringSearchCriteria? Name { get; set; }
}