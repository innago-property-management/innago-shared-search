namespace UnitTests.Search.TypeSearchExpressions;

using Innago.Shared.Search.PropertySearchExpressions;
using Innago.Shared.Search.TypeSearchExpressions;

[UnitTest(nameof(StringSearchExpression))]
public class StringSearchExpressionTests
{
    private StringSearchExpression Target { get; } = new();

    [Fact]
    public void StringContainsExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<StringContainsSearchExpression?>(() => this.Target.StringContainsExpression);
        PropertyChecker.CheckInvariance(() => this.Target.StringContainsExpression);
    }

    [Fact]
    public void StringDoesNotContainExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<StringDoesNotContainSearchExpression?>(() => this.Target.StringDoesNotContainExpression);
        PropertyChecker.CheckInvariance(() => this.Target.StringDoesNotContainExpression);
    }

    [Fact]
    public void StringDoesNotEndWithExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<StringDoesNotEndWithSearchExpression?>(() => this.Target.StringDoesNotEndWithExpression);
        PropertyChecker.CheckInvariance(() => this.Target.StringDoesNotEndWithExpression);
    }

    [Fact]
    public void StringDoesNotStartWithExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<StringDoesNotStartWithSearchExpression?>(() => this.Target.StringDoesNotStartWithExpression);
        PropertyChecker.CheckInvariance(() => this.Target.StringDoesNotStartWithExpression);
    }

    [Fact]
    public void StringEndsWithExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<StringEndsWithSearchExpression?>(() => this.Target.StringEndsWithExpression);
        PropertyChecker.CheckInvariance(() => this.Target.StringEndsWithExpression);
    }

    [Fact]
    public void StringStartsWithExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<StringStartsWithSearchExpression?>(() => this.Target.StringStartsWithExpression);
        PropertyChecker.CheckInvariance(() => this.Target.StringStartsWithExpression);
    }
}