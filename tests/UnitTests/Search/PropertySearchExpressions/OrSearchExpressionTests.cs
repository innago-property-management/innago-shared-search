namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;
using Innago.Shared.Search.TypeSearchExpressions;

using SortOrder;

[UnitTest(nameof(OrSearchExpression<int>))]
public class OrSearchExpressionTests : OrSearchExpressionTestsBase<OrSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnCorrectExpression()
    {
        OrSearchExpression<int> searchExpression = new ComparableSearchCriteria<int>[]
        {
            new() { GreaterThanSearchExpression = 2 },
            new() { LessThanSearchExpression = 9 },
            new() { NotEqualToSearchExpression = 3 },
        };

        ParameterExpression parameter = Expression.Parameter(typeof(Dummy), "d");
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.OrElse);
    }
}
