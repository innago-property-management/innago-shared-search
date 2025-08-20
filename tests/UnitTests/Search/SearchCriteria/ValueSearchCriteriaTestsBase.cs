namespace UnitTests.Search.SearchCriteria;

using Innago.Shared.Search.SearchCriteria;

using JetBrains.Annotations;

[UsedImplicitly]
[UnitTest(nameof(ValueSearchCriteria<int>))]
public class ValueSearchCriteriaTests : ValueSearchCriteriaTestsBase<ValueSearchCriteria<int>, int>;

public abstract class ValueSearchCriteriaTestsBase<TValueSearchCriteria, TMember>
    where TValueSearchCriteria : ValueSearchCriteria<TMember>, new()
{
    private TValueSearchCriteria Target { get; } = new();

    [Fact]
    public void AndShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<IEnumerable<ValueSearchCriteria<TMember>>?>(() => this.Target.And);
        PropertyChecker.CheckInvariance(() => this.Target.And);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void AndShouldSetExpression(bool noValue)
    {
        var valueSearchCriteria = new ValueSearchCriteria<TMember>();
        this.Target.And = noValue ? null : new[] { valueSearchCriteria };

        if (noValue)
        {
            this.Target.AndSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.AndSearchExpression.Should().NotBeNull();
        }
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void EqualToShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<TMember>();
        this.Target.EqualTo = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.EqualToSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.EqualToSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void GreaterThanOrEqualToShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<TMember>?>(() => this.Target.GreaterThanOrEqualTo);
        PropertyChecker.CheckInvariance(() => this.Target.GreaterThanOrEqualTo);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void GreaterThanOrEqualToShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<TMember>();
        this.Target.GreaterThanOrEqualTo = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.GreaterThanOrEqualToSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.GreaterThanOrEqualToSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void GreaterThanShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<TMember>?>(() => this.Target.GreaterThan);
        PropertyChecker.CheckInvariance(() => this.Target.GreaterThan);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void GreaterThanShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<TMember>();
        this.Target.GreaterThan = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.GreaterThanSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.GreaterThanSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void InShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValues<TMember>?>(() => this.Target.In);
        PropertyChecker.CheckInvariance(() => this.Target.In);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void InShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValues<TMember>();
        this.Target.In = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.InSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.InSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void LessThanOrEqualToShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<TMember>?>(() => this.Target.LessThanOrEqualTo);
        PropertyChecker.CheckInvariance(() => this.Target.LessThanOrEqualTo);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void LessThanOrEqualToShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<TMember>();
        this.Target.LessThanOrEqualTo = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.LessThanOrEqualToSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.LessThanOrEqualToSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void LessThanShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<TMember>?>(() => this.Target.LessThan);
        PropertyChecker.CheckInvariance(() => this.Target.LessThan);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void LessThanShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<TMember>();
        this.Target.LessThan = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.LessThanSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.LessThanSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void NotEqualToShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValue<TMember>?>(() => this.Target.NotEqualTo);
        PropertyChecker.CheckInvariance(() => this.Target.NotEqualTo);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void NotEqualToShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValue<TMember>();
        this.Target.NotEqualTo = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.NotEqualToSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.NotEqualToSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void NotInShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<SearchValues<TMember>?>(() => this.Target.NotIn);
        PropertyChecker.CheckInvariance(() => this.Target.NotIn);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void NotInShouldSetExpression(bool noValue)
    {
        var searchValue = new SearchValues<TMember>();
        this.Target.NotIn = noValue ? null : searchValue;

        if (noValue)
        {
            this.Target.NotInSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.NotInSearchExpression.Should().NotBeNull();
        }
    }

    [Fact]
    public void OrShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<IEnumerable<ValueSearchCriteria<TMember>>?>(() => this.Target.Or);
        PropertyChecker.CheckInvariance(() => this.Target.Or);
    }

    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public void OrShouldSetExpression(bool noValue)
    {
        var valueSearchCriteria = new ValueSearchCriteria<TMember>();
        this.Target.Or = noValue ? null : new[] { valueSearchCriteria };

        if (noValue)
        {
            this.Target.OrSearchExpression.Should().BeNull();
        }
        else
        {
            this.Target.OrSearchExpression.Should().NotBeNull();
        }
    }
}