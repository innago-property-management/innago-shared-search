namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(StringEndsWithSearchExpression))]
public class StringEndsWithSearchExpressionTests
{
    [Fact]
    public void GetExpressionShouldReturnTheCorrectExpression()
    {
        const string value = "a";
        StringEndsWithSearchExpression searchExpression = value;

        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Name));

        var actual = (searchExpression as ISearchExpression).GetExpression(member) as MethodCallExpression;

        actual!.Method.Should().BeSameAs(typeof(string).GetMethod(nameof(string.EndsWith), [typeof(string)]));
    }

    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<StringEndsWithSearchExpression> func = () =>
        {
            SearchValue<string> searchValue = "b";
            StringEndsWithSearchExpression expression = searchValue;

            return expression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromString()
    {
        Func<StringEndsWithSearchExpression> func = () =>
        {
            StringEndsWithSearchExpression expression = "a";

            return expression;
        };

        func.Should().NotThrow();
    }
}
