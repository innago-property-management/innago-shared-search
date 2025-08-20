namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class GreaterThanSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : GreaterThanSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<GreaterThanSearchExpression<TMember?>> func = () =>
        {
            SearchValue<TMember?> searchValue = default(TMember);
            GreaterThanSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<GreaterThanSearchExpression<TMember?>> func = () =>
        {
            GreaterThanSearchExpression<TMember?> searchExpression = default(TMember);

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldImplementISearchExpression()
    {
        typeof(TSearchExpression).Should().Implement<ISearchExpression>();
    }
}