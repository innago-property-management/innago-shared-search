namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(StringDoesNotStartWithSearchExpression))]
public class StringDoesNotStartWithSearchExpressionTests
{
    [Fact]
    public void GetExpressionShouldReturnTheCorrectExpression()
    {
        const string value = "a";
        StringDoesNotStartWithSearchExpression searchExpression = value;

        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Name));

        var actual = (searchExpression as ISearchExpression).GetExpression(member) as UnaryExpression;

        var methodCall = actual!.Operand as MethodCallExpression;

        methodCall!.Method.Should().BeSameAs(typeof(string).GetMethod(nameof(string.StartsWith), [typeof(string)]));
    }

    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<StringDoesNotStartWithSearchExpression> func = () =>
        {
            SearchValue<string> searchValue = "b";
            StringDoesNotStartWithSearchExpression expression = searchValue;

            return expression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromString()
    {
        Func<StringDoesNotStartWithSearchExpression> func = () =>
        {
            StringDoesNotStartWithSearchExpression expression = "a";

            return expression;
        };

        func.Should().NotThrow();
    }
}