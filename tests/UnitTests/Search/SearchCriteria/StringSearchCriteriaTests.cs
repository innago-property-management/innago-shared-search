namespace UnitTests.Search.SearchCriteria;

using Innago.Shared.Search.SearchCriteria;

[UnitTest(nameof(StringSearchCriteria))]
public class StringSearchCriteriaTests : ValueSearchCriteriaTestsBase<StringSearchCriteria, string>
{
    private StringSearchCriteria Target { get; } = new();

    [Fact]
    public void ContainsShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<string>?>(() => this.Target.Contains);
        PropertyChecker.CheckInvariance(() => this.Target.Contains);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void ContainsShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<string>();
        this.Target.Contains = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.StringContainsExpression.Should().BeNull();
        }
        else
        {
            this.Target.StringContainsExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void DoesNotContainShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<string>?>(() => this.Target.DoesNotContain);
        PropertyChecker.CheckInvariance(() => this.Target.DoesNotContain);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void DoesNotContainShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<string>();
        this.Target.DoesNotContain = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.StringDoesNotContainExpression.Should().BeNull();
        }
        else
        {
            this.Target.StringDoesNotContainExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void DoesNotEndWithShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<string>?>(() => this.Target.DoesNotEndWith);
        PropertyChecker.CheckInvariance(() => this.Target.DoesNotEndWith);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void DoesNotEndWithShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<string>();
        this.Target.DoesNotEndWith = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.StringDoesNotEndWithExpression.Should().BeNull();
        }
        else
        {
            this.Target.StringDoesNotEndWithExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void DoesNotStartWithShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<string>?>(() => this.Target.DoesNotStartWith);
        PropertyChecker.CheckInvariance(() => this.Target.DoesNotStartWith);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void DoesNotStartWithShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<string>();
        this.Target.DoesNotStartWith = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.StringDoesNotStartWithExpression.Should().BeNull();
        }
        else
        {
            this.Target.StringDoesNotStartWithExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void EndsWithShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<string>?>(() => this.Target.EndsWith);
        PropertyChecker.CheckInvariance(() => this.Target.EndsWith);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void EndsWithShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<string>();
        this.Target.EndsWith = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.StringEndsWithExpression.Should().BeNull();
        }
        else
        {
            this.Target.StringEndsWithExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void StartsWithShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<string>?>(() => this.Target.StartsWith);
        PropertyChecker.CheckInvariance(() => this.Target.StartsWith);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void StartsWithShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<string>();
        this.Target.StartsWith = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.StringStartsWithExpression.Should().BeNull();
        }
        else
        {
            this.Target.StringStartsWithExpression.Should().NotBeNull();
        }
    }
}