using System.Linq.Expressions;

namespace Taazaa.Shared.DevKit.Framework.Search.SearchCriteria;

internal class ParameterReplacingExpressionVisitor : ExpressionVisitor
{
    private readonly ParameterExpression replacement;

    public ParameterReplacingExpressionVisitor(ParameterExpression replacement)
    {
        this.replacement = replacement;
    }

    protected override Expression VisitLambda<T>(Expression<T> node)
    {
        return Expression.Lambda<T>(this.Visit(node.Body)!, node.Parameters);
    }

    protected override Expression VisitParameter(ParameterExpression node)
    {
        return this.replacement;
    }
}