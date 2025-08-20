namespace UnitTests.Search.PropertySearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;

public abstract class LessThanOrEqualToSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : LessThanOrEqualToSearchExpression<TMember>
{
    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<LessThanOrEqualToSearchExpression<TMember?>> func = () =>
        {
            SearchValue<TMember?> searchValue = default(TMember);
            LessThanOrEqualToSearchExpression<TMember?> searchExpression = searchValue;

            return searchExpression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromValue()
    {
        Func<LessThanOrEqualToSearchExpression<TMember?>> func = () =>
        {
            LessThanOrEqualToSearchExpression<TMember?> searchExpression = default(TMember);

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