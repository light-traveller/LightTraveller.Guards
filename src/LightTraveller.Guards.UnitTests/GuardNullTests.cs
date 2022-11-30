using static LightTraveller.Guards.UnitTests.TestHelpers;

namespace LightTraveller.Guards.UnitTests;

public class GuardNullTests
{
    [Fact]
    public void WithNull_GuardNull_Should_ThrowArgumentNullException()
    {
        object? nullObj = null;
        _ = Assert.Throws<ArgumentNullException>(() => _ = Guard.Null(nullObj));
    }

    [Fact]
    public void WithNullAndCustomMessage_GuardNull_Should_ThrowArgumentNullExceptionWithCustomMessage()
    {
        object? nullObj = null;
        var exception = Assert.Throws<ArgumentNullException>(() => _ = Guard.Null(nullObj, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(nullObj)), exception.Message);
    }

    [Fact]
    public void WithNotNull_GuardNull_ShouldNot_Throw()
    {
        object? obj = new object();
        var tested = Guard.Null(obj);
        Assert.Same(obj, tested);
    }
}
