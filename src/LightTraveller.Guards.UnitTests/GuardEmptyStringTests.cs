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
    public void WithNullString_GuradEmpty_Should_ThrowArgumentNullExpetion()
    {
        string? nullString = null;
        _ = Assert.Throws<ArgumentNullException>(() => _ = Guard.Empty(nullString));
    }

    [Fact]
    public void WithNotEmptyStrings_GuradEmpty_ShouldNot_Throw()
    {
        var input = "A string";
        Assert.Equal(input, Guard.Empty(input));
    }
}
