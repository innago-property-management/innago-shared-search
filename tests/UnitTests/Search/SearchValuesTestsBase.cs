namespace UnitTests.Search;

public abstract class SearchValuesTestsBase<TSearchValue, TMember>
    where TSearchValue : SearchValues<TMember>, new()
{
    private TSearchValue Target { get; } = new();

    [Fact]
    public void ItShouldBeAssignableFromTheValue()
    {
        Func<SearchValues<TMember?>> act = () =>
        {
            SearchValues<TMember?> searchValue = new[]
            {
                default(TMember),
                default(TMember),
            };

            return searchValue;
        };

        act.Should().NotThrow();
    }

    [Fact]
    public void ValuesShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<IEnumerable<TMember?>?>(() => this.Target.Values);
        PropertyChecker.CheckInvariance(() => this.Target.Values);
    }
}
