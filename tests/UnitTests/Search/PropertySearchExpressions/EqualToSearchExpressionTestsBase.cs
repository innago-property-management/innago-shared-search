namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class EqualToSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : EqualToSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<EqualToSearchExpression<TMember?>> func = () =>
        {
            SearchValue<TMember?> searchValue = default(TMember);
            EqualToSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<EqualToSearchExpression<TMember?>> func = () =>
        {
            EqualToSearchExpression<TMember?> searchExpression = default(TMember);

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