namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class NotInSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : NotInSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<NotInSearchExpression<TMember?>> func = () =>
        {
            SearchValues<TMember?> searchValue = new[] { default(TMember) };
            NotInSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<NotInSearchExpression<TMember?>> func = () =>
        {
            NotInSearchExpression<TMember?> searchExpression = new[] { default(TMember) };

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