namespace UnitTests.Search.SearchCriteria;

using Innago.Shared.Search.SearchCriteria;

[UnitTest(nameof(IComparableSearchCriteria<int>))]
public class ComparableSearchCriteriaInterfaceTests
{
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    private IComparableSearchCriteria<int> Target { get; } = null!;

    [Fact]
    public void ItShouldHaveReadWritePropEqualTo()
    {
        PropertyChecker.CheckProperty<SearchValue<int>>(() => this.Target.EqualTo, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropGreaterThan()
    {
        PropertyChecker.CheckProperty<SearchValue<int>>(() => this.Target.GreaterThan, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropGreaterThanOrEqualTo()
    {
        PropertyChecker.CheckProperty<SearchValue<int>>(() => this.Target.GreaterThanOrEqualTo, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropIn()
    {
        PropertyChecker.CheckProperty<SearchValues<int>>(() => this.Target.In, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropLessThan()
    {
        PropertyChecker.CheckProperty<SearchValue<int>>(() => this.Target.LessThan, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropLessThanOrEqualTo()
    {
        PropertyChecker.CheckProperty<SearchValue<int>>(() => this.Target.LessThanOrEqualTo, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropNotEqualTo()
    {
        PropertyChecker.CheckProperty<SearchValue<int>>(() => this.Target.NotEqualTo, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldHaveReadWritePropNotIn()
    {
        PropertyChecker.CheckProperty<SearchValues<int>>(() => this.Target.NotIn, skipDefaultValueCheck: true);
    }
}