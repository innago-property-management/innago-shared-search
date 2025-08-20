namespace UnitTests.Search.TypeSearchExpressions;

using System.Linq.Expressions;

using Innago.Shared.Search.PropertySearchExpressions;
using Innago.Shared.Search.TypeSearchExpressions;

using JetBrains.Annotations;

[UsedImplicitly]
[UnitTest(nameof(ComparableSearchCriteria<int>))]
public class ComparableSearchCriteriaTests : ComparableSearchCriteriaTestsBase<ComparableSearchCriteria<int>, int>;

public abstract class ComparableSearchCriteriaTestsBase<TSearchExpression, TMember>
    where TSearchExpression : ComparableSearchCriteria<TMember>, new()
{
    private TSearchExpression Target { get; } = new();

    [Fact]
    public void AndSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<AndSearchExpression<TMember>?>(() => this.Target.AndSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.AndSearchExpression);
    }

    [Fact]
    public void EqualToSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<EqualToSearchExpression<TMember>?>(() => this.Target.EqualToSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.EqualToSearchExpression);
    }

    [Fact]
    public void GetExpressionShouldReturnAndAlsoAggregate()
    {
        NotEqualToSearchExpression<TMember> notEqualToSearchExpression = default(TMember);
        EqualToSearchExpression<TMember> equalToSearchExpression = default(TMember);

        ISearchExpression searchExpression = new ComparableSearchCriteria<TMember>
        {
            NotEqualToSearchExpression = notEqualToSearchExpression,
            EqualToSearchExpression = equalToSearchExpression,
        };

        MemberExpression member = Expression.Property(Expression.Parameter(typeof(string)), nameof(string.Length));

        Expression actual = searchExpression.GetExpression(member);

        actual.NodeType.Should().Be(ExpressionType.AndAlso);
        (actual as BinaryExpression)!.Left.Should().BeEquivalentTo((equalToSearchExpression as ISearchExpression).GetExpression(member));
        (actual as BinaryExpression)!.Right.Should().BeEquivalentTo((notEqualToSearchExpression as ISearchExpression).GetExpression(member));
    }

    [Fact]
    public void GreaterThanOrEqualToSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<GreaterThanOrEqualToSearchExpression<TMember>?>(() => this.Target.GreaterThanOrEqualToSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.GreaterThanOrEqualToSearchExpression);
    }

    [Fact]
    public void GreaterThanSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<GreaterThanSearchExpression<TMember>?>(() => this.Target.GreaterThanSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.GreaterThanSearchExpression);
    }

    [Fact]
    public void InSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<InSearchExpression<TMember>?>(() => this.Target.InSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.InSearchExpression);
    }

    [Fact]
    public void LessThanOrEqualToSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<LessThanOrEqualToSearchExpression<TMember>?>(() => this.Target.LessThanOrEqualToSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.LessThanOrEqualToSearchExpression);
    }

    [Fact]
    public void LessThanSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<LessThanSearchExpression<TMember>?>(() => this.Target.LessThanSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.LessThanSearchExpression);
    }

    [Fact]
    public void NotEqualToSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<NotEqualToSearchExpression<TMember>?>(() => this.Target.NotEqualToSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.NotEqualToSearchExpression);
    }

    [Fact]
    public void NotInSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<NotInSearchExpression<TMember>?>(() => this.Target.NotInSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.NotInSearchExpression);
    }

    [Fact]
    public void OrSearchExpressionShouldBeWellBehaved()
    {
        PropertyChecker.CheckProperty<OrSearchExpression<TMember>?>(() => this.Target.OrSearchExpression);
        PropertyChecker.CheckInvariance(() => this.Target.OrSearchExpression);
    }
}