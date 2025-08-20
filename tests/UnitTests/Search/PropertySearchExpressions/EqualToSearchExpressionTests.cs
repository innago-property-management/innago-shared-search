namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(EqualToSearchExpression<int>))]
public class EqualToSearchExpressionTests : EqualToSearchExpressionTestsBase<EqualToSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnEqualExpression()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        SearchValue<int> searchValue = 1;
        EqualToSearchExpression<int> searchExpression = searchValue;

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.Equal);
        (actual as BinaryExpression)!.Left.Should().Be(member);
        (actual as BinaryExpression)!.Right.Should().BeEquivalentTo(Expression.Constant(searchValue.Value));
    }
}
