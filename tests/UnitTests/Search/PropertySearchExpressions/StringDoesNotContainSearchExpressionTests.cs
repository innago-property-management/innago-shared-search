namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(StringDoesNotContainSearchExpression))]
public class StringDoesNotContainSearchExpressionTests
{
    [Fact]
    public void GetExpressionShouldReturnTheCorrectExpression()
    {
        const string value = "a";
        StringDoesNotContainSearchExpression searchExpression = value;

        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Name));

        var actual = (searchExpression as ISearchExpression).GetExpression(member) as UnaryExpression;

        var methodCall = actual!.Operand as MethodCallExpression;

        methodCall!.Method.Should().BeSameAs(typeof(string).GetMethod(nameof(string.Contains), [typeof(string)]));
    }

    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<StringDoesNotContainSearchExpression> func = () =>
        {
            SearchValue<string> searchValue = "b";
            StringDoesNotContainSearchExpression expression = searchValue;

            return expression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromString()
    {
        Func<StringDoesNotContainSearchExpression> func = () =>
        {
            StringDoesNotContainSearchExpression expression = "a";

            return expression;
        };

        func.Should().NotThrow();
    }
}