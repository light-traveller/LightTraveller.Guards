using LightTraveller.Guards;

namespace LightTraveller.Guards.UnitTests;

public class GuardNullTests
{
    [Fact]
    public void WithNull_GuardNull_Should_ThrowArgumentNullException_()
    {
        object? nullObj = null;
        _ = Assert.Throws<ArgumentNullException>(() => _ = Guard.Null(nullObj));
    }

    [Fact]
    public void WithNotNull_GuardNull_ShouldNot_Throw()
    {
        object? obj = new object();
        var tested = Guard.Null(obj);
        Assert.Same(obj, tested);
    }
}
