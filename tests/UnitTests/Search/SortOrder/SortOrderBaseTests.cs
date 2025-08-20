// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace UnitTests.Search.SortOrder;

using System.ComponentModel.DataAnnotations;
using System.Text.Json;

using Innago.Shared.Search.SortOrder;

using Xunit.Abstractions;

[UnitTest(nameof(SortOrderBase<DummySortOrder>))]
public class SortOrderBaseTests : SortOrderBaseTestsBase<DummySortOrder, Dummy>
{
    public SortOrderBaseTests(ITestOutputHelper outputHelper) : base(outputHelper)
    {
    }

    [Fact]
    public void ApplyShouldUseDefaultIfNoneSet()
    {
        var data = new[]
        {
            new Dummy { Id = 1, Name = "a" },
            new Dummy { Id = 21, Name = "w" },
            new Dummy { Id = 2, Name = "x" },
            new Dummy { Id = 15, Name = "m" },
        };

        List<int> expected = data.OrderBy(d => d.Id).Select(d => d.Id).ToList();

        var s = new DummySortOrder();
        List<int> actual = s.Apply(data.AsQueryable()).Select(d => d.Id).ToList();
        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void ApplyShouldUseSortOrderSet()
    {
        var data = new[]
        {
            new Dummy { Id = 1, Name = "a" },
            new Dummy { Id = 21, Name = "w" },
            new Dummy { Id = 2, Name = "x" },
            new Dummy { Id = 15, Name = "m" },
        };

        List<Dummy> expected = data.OrderByDescending(d => d.Name).ToList();

        var s = new DummySortOrder { Name = SortOrderDirection.Descending };
        List<Dummy> actual = s.Apply(data.AsQueryable()).ToList();
        this.OutputHelper.WriteLine(JsonSerializer.Serialize(actual));

        actual.Should().BeEquivalentTo(expected, options => options.WithStrictOrdering());
    }

    [Fact]
    public void ItShouldBeInvalidIfMoreThanOnePropsSet()
    {
        var t = new DummySortOrder { Name = SortOrderDirection.Ascending, Id = SortOrderDirection.Ascending };
        var validationContext = new ValidationContext(t);
        Action act = () => Validator.ValidateObject(t, validationContext, true);

        act.Should().Throw<ValidationException>();
    }

    [Fact]
    public void ItShouldBeValidIfNoPropsSet()
    {
        var t = new DummySortOrder();
        var validationContext = new ValidationContext(t);
        Action act = () => Validator.ValidateObject(t, validationContext, true);

        act.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeValidIfOnePropsSet()
    {
        var t = new DummySortOrder { Id = SortOrderDirection.Ascending };
        var validationContext = new ValidationContext(t);
        Action act = () => Validator.ValidateObject(t, validationContext, true);

        act.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeValidIfOnePropsSet2()
    {
        var t = new DummySortOrder { Name = SortOrderDirection.Ascending };
        var validationContext = new ValidationContext(t);
        Action act = () => Validator.ValidateObject(t, validationContext, true);

        act.Should().NotThrow();
    }
}

public class DummySortOrder : SortOrderBase<Dummy>
{
    public SortOrderDirective<int>? Id { get; set; }
    public SortOrderDirective<string>? Name { get; set; }

    protected override (string Name, ISortOrderDirective Directive) DefaultSort =>
        (nameof(Dummy.Id), new SortOrderDirective<int> { Direction = SortOrderDirection.Ascending });
}
