namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;
using System.Reflection;

using Innago.Shared.Search.PropertySearchExpressions;

[UnitTest(nameof(ISearchExpression))]
public class SearchExpressionInterfaceTests
{
    [Fact]
    public void ItShouldBeAnInterface()
    {
        typeof(ISearchExpression).IsInterface.Should().BeTrue();
    }

    [Fact]
    public void ItShouldDefineGetExpression()
    {
        MethodInfo method = typeof(ISearchExpression).GetMethod("GetExpression")!;

        method.ReturnType.Should().Be<Expression>();
        method.GetParameters().Single().ParameterType.Should().Be<MemberExpression>();
    }
}
