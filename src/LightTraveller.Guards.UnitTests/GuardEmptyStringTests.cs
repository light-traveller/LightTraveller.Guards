using static LightTraveller.Guards.UnitTests.TestHelpers;

namespace LightTraveller.Guards.UnitTests;

public class GuardEmptyStringTests
{
    [Fact]
    public void WithEmptyString_GuradEmpty_Should_ThrowArgumentExpetion()
    {
        const string EMPTY_STRING = "";
        _ = Assert.Throws<ArgumentException>(() => _ = Guard.Empty(EMPTY_STRING));
    }

    [Fact]
    public void WithEmptyStringAndCustomMessage_GuradEmpty_Should_ThrowArgumentExpetionWithCustomMessage()
    {
        const string EMPTY_STRING = "";
        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Empty(EMPTY_STRING, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(EMPTY_STRING)), exception.Message);
    }

    [Fact]
    public void WithNullString_GuradEmpty_Should_ThrowArgumentNullExpetion()
    {
        string? nullString = null;
        _ = Assert.Throws<ArgumentNullException>(() => _ = Guard.Empty(nullString));
    }

    [Fact]
    public void WithNullStringAndCustomMessage_GuradEmpty_Should_ThrowArgumentNullExpetionWithCustomMessage()
    {
        string? nullString = null;
        var exception = Assert.Throws<ArgumentNullException>(() => _ = Guard.Empty(nullString, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(nullString)), exception.Message);
    }

    [Fact]
    public void WithNotEmptyStrings_GuradEmpty_ShouldNot_Throw()
    {
        var input = "A string";
        Assert.Equal(input, Guard.Empty(input));
    }
}
