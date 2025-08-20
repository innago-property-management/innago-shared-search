namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(GreaterThanSearchExpression<int>))]
public class GreaterThanSearchExpressionTests : GreaterThanSearchExpressionTestsBase<GreaterThanSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnCorrectExpression()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        SearchValue<int> searchValue = 1;
        GreaterThanSearchExpression<int> searchExpression = searchValue;

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.GreaterThan);
        (actual as BinaryExpression)!.Left.Should().Be(member);
        (actual as BinaryExpression)!.Right.Should().BeEquivalentTo(Expression.Constant(searchValue.Value));
    }
}
