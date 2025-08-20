namespace UnitTests.Search.SortOrder;

using System.ComponentModel.DataAnnotations;
using System.Reflection;

using Innago.Shared.Search.SortOrder;

using Moq;

using Xunit.Abstractions;

public abstract class SortOrderBaseTestsBase<T, TSource>
    where T : SortOrderBase<TSource>
{
    protected SortOrderBaseTestsBase(ITestOutputHelper outputHelper)
    {
        this.OutputHelper = outputHelper;
        this.Target = Mock.Of<T>();
    }

    private protected ITestOutputHelper OutputHelper { get; }

    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    private protected T Target { get; }

    [Fact]
    public void ItShouldHaveReadOnlyAbstractPropDefaultSort()
    {
        PropertyInfo? property = typeof(SortOrderBase<TSource>).GetProperty("DefaultSort", BindingFlags.Instance | BindingFlags.NonPublic);

        property!.CanRead.Should().BeTrue();
        property.CanWrite.Should().BeFalse();
        property.GetMethod!.IsAbstract.Should().BeTrue();

        property.PropertyType.Should().Be<(string Name, ISortOrderDirective Directive)>();
    }

    [Fact]
    public void ItShouldImplementIValidatableObject()
    {
        typeof(SortOrderBase<>).Should().Implement<IValidatableObject>();
    }
}
