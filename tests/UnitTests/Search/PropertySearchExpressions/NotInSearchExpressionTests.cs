namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;
using System.Reflection;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(NotInSearchExpression<int>))]
public class NotInSearchExpressionTests : NotInSearchExpressionTestsBase<NotInSearchExpression<int>, int>
{
    [Fact]
    public void GetExpressionShouldReturnCorrectExpression()
    {
        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Id));

        const int searchValue = 1;
        NotInSearchExpression<int> searchExpression = new[] { searchValue };

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.Not);

        var methodCallExpression = ((UnaryExpression)actual).Operand as MethodCallExpression;

        MethodInfo expectedMethod = typeof(Enumerable).GetMethods().First(m => m.Name == nameof(Enumerable.Contains) && m.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(int));

        methodCallExpression!.Method.Should().BeSameAs(expectedMethod);
        methodCallExpression.Arguments[0].Should().BeEquivalentTo(Expression.Constant(new[] { searchValue }));
        methodCallExpression.Arguments[1].Should().BeEquivalentTo(member);
    }
}
