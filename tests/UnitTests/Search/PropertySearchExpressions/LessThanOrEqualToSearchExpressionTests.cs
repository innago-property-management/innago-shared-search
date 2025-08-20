namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(LessThanOrEqualToSearchExpression<int>))]
public class LessThanOrEqualToSearchExpressionTests : LessThanOrEqualToSearchExpressionTestsBase<LessThanOrEqualToSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnCorrectExpression()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        SearchValue<int> searchValue = 1;
        LessThanOrEqualToSearchExpression<int> searchExpression = searchValue;

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.LessThanOrEqual);
        (actual as BinaryExpression)!.Left.Should().Be(member);
        (actual as BinaryExpression)!.Right.Should().BeEquivalentTo(Expression.Constant(searchValue.Value));
    }
}
