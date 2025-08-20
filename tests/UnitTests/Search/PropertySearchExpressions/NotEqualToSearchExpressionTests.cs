namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(NotEqualToSearchExpression<int>))]
public class NotEqualToSearchExpressionTests : NotEqualToSearchExpressionTestsBase<NotEqualToSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnEqualExpression()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        SearchValue<int> searchValue = 1;
        NotEqualToSearchExpression<int> searchExpression = searchValue;

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.NotEqual);
        (actual as BinaryExpression)!.Left.Should().Be(member);
        (actual as BinaryExpression)!.Right.Should().BeEquivalentTo(Expression.Constant(searchValue.Value));
    }
}
