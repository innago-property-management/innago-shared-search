namespace UnitTests.Search;

public abstract class SearchValueTestsBase<TSearchValue, TMember>
    where TSearchValue : SearchValue<TMember>, new()
{
    private TSearchValue Target { get; } = new();

    [Fact]
    public void ItShouldBeAssignableFromTheValue()
    {
        Func<SearchValue<TMember?>> act = () =>
        {
            SearchValue<TMember?> searchValue = default(TMember);

            return searchValue;
        };

        act.Should().NotThrow();
    }

    [Fact]
    public void ValueShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<TMember>(() => this.Target.Value);
        PropertyChecker.CheckInvariance(() => this.Target.Value);
    }
}