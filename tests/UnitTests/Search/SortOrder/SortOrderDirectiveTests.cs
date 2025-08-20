namespace UnitTests.Search.SortOrder;

using System.Linq.Expressions;
using System.Text.Json;

using Innago.Shared.Search.SortOrder;

using Moq;

using Xunit.Abstractions;

[UnitTest(nameof(SortOrderDirective<object>))]
public class SortOrderDirectiveTests
{
    private static readonly IQueryable<Dummy> TestData = new[]
    {
        new Dummy { Id = 1, Name = Guid.NewGuid().ToString("N") },
        new Dummy { Id = 21, Name = Guid.NewGuid().ToString("N") },
        new Dummy { Id = 2, Name = Guid.NewGuid().ToString("N") },
        new Dummy { Id = 4, Name = "a" },
        new Dummy { Id = 3, Name = "a" },
        new Dummy { Id = 5, Name = "a" },
    }.AsQueryable();

    public SortOrderDirectiveTests(ITestOutputHelper outputHelper)
    {
        this.OutputHelper = outputHelper;
        this.Target = new Mock<SortOrderDirective<int>> { CallBase = true }.Object;
    }

    private ITestOutputHelper OutputHelper { get; }
    private SortOrderDirective<int> Target { get; }

    [Fact]
    public void ApplyShouldCorrectlyHandleSingleAscending()
    {
        IOrderedQueryable<Dummy> actual = (this.Target as ISortOrderDirective).Apply(SortOrderDirectiveTests.TestData, "Id");

        actual.Should().BeInAscendingOrder(dummy => dummy.Id);
    }

    [Fact]
    public void ApplyShouldCorrectlyHandleSingleDescending()
    {
        SortOrderDirective<int> directive = SortOrderDirection.Descending;

        IOrderedQueryable<Dummy> actual = (directive as ISortOrderDirective).Apply(SortOrderDirectiveTests.TestData, "Id");

        actual.Should().BeInDescendingOrder(dummy => dummy.Id);
    }

    [Fact]
    public void ApplyShouldCorrectlyHandleSubsequent()
    {
        IOrderedQueryable<Dummy> expected = SortOrderDirectiveTests.TestData.OrderBy(dummy => dummy.Name).ThenBy(dummy => dummy.Id);

        SortOrderDirective<int> directive = SortOrderDirection.Ascending;

        IOrderedQueryable<Dummy> actual = (directive as ISortOrderDirective).Apply(SortOrderDirectiveTests.TestData.OrderBy(dummy => dummy.Name), "Id");

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().ContainInOrder(expected);
    }

    [Fact]
    public void ApplyShouldCorrectlyHandleSubsequentDescending()
    {
        List<int> expected = SortOrderDirectiveTests.TestData.OrderBy(dummy => dummy.Name).ThenByDescending(dummy => dummy.Id).Select(d => d.Id).ToList();

        SortOrderDirective<int> directive = SortOrderDirection.Descending;

        List<int> actual = (directive as ISortOrderDirective).Apply(SortOrderDirectiveTests.TestData.OrderBy(dummy => dummy.Name), "Id").Select(d => d.Id)
            .ToList();

        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().ContainInOrder(expected);
    }

    [Fact]
    public void ApplyShouldUseGetSelector()
    {
        const string propertyName = "Id";

        (this.Target as ISortOrderDirective).Apply(SortOrderDirectiveTests.TestData, propertyName);

        Mock.Get(this.Target)
            .Verify(directive => directive.GetSelector<Dummy>(propertyName));
    }

    [Fact]
    public void DirectionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SortOrderDirection>(() => this.Target.Direction, expectedDefaultValue: SortOrderDirection.Ascending);
        PropertyChecker.CheckInvariance(() => this.Target.Direction);
    }

    [Fact]
    public void GetSelectorShouldReturnCorrectLambda()
    {
        Expression<Func<Dummy, int>> actual = this.Target.GetSelector<Dummy>("Id");

        Func<Dummy, int> func = actual.Compile();

        var d = new Dummy { Id = 2 };

        func(d).Should().Be(d.Id);
    }

    [Theory]
    [InlineData(SortOrderDirection.Ascending)]
    [InlineData(SortOrderDirection.Descending)]
    public void ItShouldBeCreatableByAssignment(SortOrderDirection direction)
    {
        SortOrderDirective<int> actual = direction;
        actual.Direction.Should().Be(direction);
    }
}

public class Dummy
{
    public int Id { get; init; }

    public bool IsSomething { get; set; }

    // ReSharper disable once UnusedMember.Global
    public bool? MightBeSomething { get; set; }

    public string? Name { get; init; }
}
