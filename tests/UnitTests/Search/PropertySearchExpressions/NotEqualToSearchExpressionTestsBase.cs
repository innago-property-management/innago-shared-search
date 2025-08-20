namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class NotEqualToSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : NotEqualToSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<NotEqualToSearchExpression<TMember?>> func = () =>
        {
            SearchValue<TMember?> searchValue = default(TMember);
            NotEqualToSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<NotEqualToSearchExpression<TMember?>> func = () =>
        {
            NotEqualToSearchExpression<TMember?> searchExpression = default(TMember);

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