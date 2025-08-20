namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;

using SortOrder;

[UnitTest(nameof(StringStartsWithSearchExpression))]
public class StringStartsWithSearchExpressionTests
{
    [Fact]
    public void GetExpressionShouldReturnTheCorrectExpression()
    {
        const string value = "a";
        StringStartsWithSearchExpression searchExpression = value;

        ParameterExpression parameter = Expression.Parameter(typeof(Dummy));
        MemberExpression member = Expression.Property(parameter, nameof(Dummy.Name));

        var actual = (searchExpression as ISearchExpression).GetExpression(member) as MethodCallExpression;

        actual!.Method.Should().BeSameAs(typeof(string).GetMethod(nameof(string.StartsWith), [typeof(string)]));
    }

    [Fact]
    public void ItShouldBeAssignableFromSearchValue()
    {
        Func<StringStartsWithSearchExpression> func = () =>
        {
            SearchValue<string> searchValue = "b";
            StringStartsWithSearchExpression expression = searchValue;

            return expression;
        };

        func.Should().NotThrow();
    }

    [Fact]
    public void ItShouldBeAssignableFromString()
    {
        Func<StringStartsWithSearchExpression> func = () =>
        {
            StringStartsWithSearchExpression expression = "a";

            return expression;
        };

        func.Should().NotThrow();
    }
}
