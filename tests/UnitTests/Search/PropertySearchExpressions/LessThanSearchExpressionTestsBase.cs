namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class LessThanSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : LessThanSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<LessThanSearchExpression<TMember?>> func = () =>
        {
            SearchValue<TMember?> searchValue = default(TMember);
            LessThanSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<LessThanSearchExpression<TMember?>> func = () =>
        {
            LessThanSearchExpression<TMember?> searchExpression = default(TMember);

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