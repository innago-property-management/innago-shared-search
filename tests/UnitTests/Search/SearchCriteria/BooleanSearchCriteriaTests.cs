namespace UnitTests.Search.SearchCriteria;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;
using Innago.Shared.Search.SearchCriteria;
using Innago.Shared.Search.TypeSearchExpressions;

using SortOrder;

[UnitTest(nameof(BooleanSearchCriteria))]
public class BooleanSearchCriteriaTests
{
    [Fact]
    public void ItShouldBeAssignableFromBool()
    {
        Func<BooleanSearchCriteria> func = () =>
        {
            BooleanSearchCriteria searchCriteria = true;

            return searchCriteria;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldCreateTheCorrectExpression()
    {
        BooleanSearchCriteria searchCriteria = true;
        MemberExpression member = Expression.Property(Expression.Parameter(typeof(Dummy)), nameof(Dummy.IsSomething));

        EqualToSearchExpression<bool> searchExpression = searchCriteria.Value!;
        Expression expected = (searchExpression as ISearchExpression).GetExpression(member);

        Expression actual = (searchCriteria as ISearchExpression).GetExpression(member);

        actual.Should().BeEquivalentTo(expected);
    }

    [Fact]
    public void ItShouldExtendComparableSearchCriteria()
    {
        typeof(BooleanSearchCriteria).Should().BeDerivedFrom<ComparableSearchCriteria<bool>>();
    }
}