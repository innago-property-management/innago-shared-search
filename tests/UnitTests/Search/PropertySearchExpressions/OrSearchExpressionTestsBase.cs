namespace UnitTests.Search.PropertySearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;
using Innago.Shared.Search.TypeSearchExpressions;

public abstract class OrSearchExpressionTestsBase<TSearchExpression, TMember>
    where TSearchExpression : OrSearchExpression<TMember>, new()
{
    private TSearchExpression Target { get; } = new();

    [Fact]
    public void GetExpressionShouldReturnFalseIfValuesEmpty()
    {
        MemberExpression member = Expression.Property(Expression.Parameter(typeof(string)), nameof(string.Length));

        OrSearchExpression<TMember> searchExpression = Array.Empty<ComparableSearchCriteria<TMember>>();

        Expression actual = (searchExpression as ISearchExpression).GetExpression(member);

        actual.Should().BeEquivalentTo(Expression.Constant(false));
    }

    [Fact]
    public void GetExpressionShouldReturnFalseIfValuesNull()
    {
        MemberExpression member = Expression.Property(Expression.Parameter(typeof(string)), nameof(string.Length));

        Expression actual = (this.Target as ISearchExpression).GetExpression(member);

        actual.Should().BeEquivalentTo(Expression.Constant(false));
    }

    [Fact]
    public void ItShouldBeAssignableFromArrayOfComparableSearchExpression()
    {
        Func<OrSearchExpression<TMember>> func = () =>
        {
            var clauses = new[]
            {
                new ComparableSearchCriteria<TMember>(),
            };

            OrSearchExpression<TMember> searchExpression = clauses;

            return searchExpression;
        };

        func.Should().NotThrow();
    }
}