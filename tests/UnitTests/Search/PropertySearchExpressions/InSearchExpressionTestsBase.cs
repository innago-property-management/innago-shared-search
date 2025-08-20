namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class InSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : InSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<InSearchExpression<TMember?>> func = () =>
        {
            SearchValues<TMember?> searchValue = new[] { default(TMember) };
            InSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<InSearchExpression<TMember?>> func = () =>
        {
            InSearchExpression<TMember?> searchExpression = new[] { default(TMember) };

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