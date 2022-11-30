using static LightTraveller.Guards.UnitTests.TestHelpers;

namespace LightTraveller.Guards.UnitTests;

public class GuardCollectionTests
{
    [Fact]
    public void WithEmptyCollection_GuardNullOrEmpty_Should_ThrowArgumentException()
    {
        var emptyArray = Array.Empty<int>();
        _ = Assert.Throws<ArgumentException>(() => _ = Guard.NullOrEmpty(emptyArray));
    }

    [Fact]
    public void WithEmptyCollectionAndCustomMessage_GuardNullOrEmpty_Should_ThrowArgumentExceptionWithCustomMessage()
    {
        var emptyArray = Array.Empty<int>();
        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.NullOrEmpty(emptyArray, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(emptyArray)), exception.Message);
    }

    [Fact]
    public void WithNullCollection_GuardNullOrEmpty_Should_ThrowArgumentNullException()
    {
        List<int>? nullList = null;
        _ = Assert.Throws<ArgumentNullException>(() => _ = Guard.NullOrEmpty(nullList));
    }

    [Fact]
    public void WithNullCollectionAndCustomMessage_GuardNullOrEmpty_Should_ThrowArgumentNullExceptionWithCustomMessage()
    {
        List<int>? nullList = null;
        var exception = Assert.Throws<ArgumentNullException>(() => _ = Guard.NullOrEmpty(nullList, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(nullList)), exception.Message);
    }

    [Fact]
    public void WithNotNullCollection_GuardNullOrEmpty_ShouldNot_Throw()
    {
        var list = new List<int> { 1 };
        Assert.Same(list, Guard.NullOrEmpty(list));
    }
}
