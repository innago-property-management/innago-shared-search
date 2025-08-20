namespace UnitTests.Search.SortOrder;

using System.Reflection;

using Innago.Shared.Search.SortOrder;

[UnitTest(nameof(ISortOrderDirective))]
public class SortOrderDirectiveInterfaceTests
{
    // ReSharper disable once ReplaceAutoPropertyWithComputedProperty
    private ISortOrderDirective Target { get; } = null!;

    [Fact]
    public void ApplyShouldHaveTheCorrectSignature()
    {
        MethodInfo? method = typeof(ISortOrderDirective).GetMethod("Apply");

        method.Should().NotBeNull();

        method.ReturnType.GetGenericTypeDefinition().Should().Be(typeof(IOrderedQueryable<>));

        List<ParameterInfo> parameters = method.GetParameters().ToList();

        parameters.Should().HaveCount(2);

        parameters[0].ParameterType.GetGenericTypeDefinition().Should().Be(typeof(IQueryable<>));

        parameters[1].ParameterType.Should().Be<string>();
    }

    [Fact]
    public void DirectionShouldBeReadWriteSortOrderDirection()
    {
        PropertyChecker.CheckProperty<SortOrderDirection>(() => this.Target.Direction, skipDefaultValueCheck: true);
    }

    [Fact]
    public void ItShouldBeAnInterface()
    {
        typeof(ISortOrderDirective).IsInterface.Should().BeTrue();
    }
}
