namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;
using System.Reflection;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(InSearchExpression<int>))]
public class InSearchExpressionTests : InSearchExpressionTestsBase<InSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnCorrectExpression()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        const int searchValue = 1;
        InSearchExpression<int> searchExpression = new[] { searchValue };

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.Call);

        MethodInfo expectedMethod = typeof(Enumerable).GetMethods().First(m => m.Name == nameof(Enumerable.Contains) && m.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(int));

        (actual as MethodCallExpression)!.Method.Should().BeSameAs(expectedMethod);
        (actual as MethodCallExpression)!.Arguments[0].Should().BeEquivalentTo(Expression.Constant(new[] { searchValue }));
        (actual as MethodCallExpression)!.Arguments[1].Should().BeEquivalentTo(member);
    }
}
