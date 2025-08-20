namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(StringDoesNotEndWithSearchExpression))]
public class StringDoesNotEndWithSearchExpressionTests
{
    [Fact]
    public void GetExpressionShouldReturnTheCorrectExpression()
    {
        const string value = "a";
        StringDoesNotEndWithSearchExpression searchExpression = value;

        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Name));

        var actual = (searchExpression as ISearchExpression).GetExpression(member) as UnaryExpression;

        var methodCall = actual!.Operand as MethodCallExpression;

        methodCall!.Method.Should().BeSameAs(typeof(string).GetMethod(nameof(string.EndsWith), [typeof(string)]));
    }

    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<StringDoesNotEndWithSearchExpression> func = () =>
        {
            SearchValue<string> searchValue = "b";
            StringDoesNotEndWithSearchExpression expression = searchValue;

            return expression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromString()
    {
        Func<StringDoesNotEndWithSearchExpression> func = () =>
        {
            StringDoesNotEndWithSearchExpression expression = "a";

            return expression;
        };

        func.Should().NotThrow();
    }
}