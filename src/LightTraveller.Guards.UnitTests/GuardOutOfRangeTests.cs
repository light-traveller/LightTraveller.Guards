namespace LightTraveller.Guards.UnitTests;
using static LightTraveller.Guards.UnitTests.TestHelpers;

public class GuardOutOfRangeTests
{
    [Fact]
    public void WithLessThanMinvalue_GuardOutOfRange_Should_ThrowArgumentOutOfRangeException()
    {
        var value = 0;
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => _ = Guard.OutOfRange(value, 2, 12));
    }

    [Fact]
    public void WithGreaterThanMaxValue_GuardOutOfRange_Should_ThrowArgumentOutOfRangeException()
    {
        var value = 20;
        _ = Assert.Throws<ArgumentOutOfRangeException>(() => _ = Guard.OutOfRange(value, 2, 12));
    }

    [Fact]
    public void WithLessThanMinvalueAndCustomMessage_GuardOutOfRange_Should_ThrowArgumentOutOfRangeExceptionWithCustomMessage()
    {
        var value = 0;
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _ = Guard.OutOfRange(value, 2, 12, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(value)), exception.Message);
    }

    [Fact]
    public void WithGreaterThanMaxValueAndCustomMessage_GuardOutOfRange_Should_ThrowArgumentOutOfRangeExceptionWithCustomMessage()
    {
        var value = 20;
        var exception = Assert.Throws<ArgumentOutOfRangeException>(() => _ = Guard.OutOfRange(value, 2, 12, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(value)), exception.Message);
    }

    [Theory]
    [InlineData(2)]
    [InlineData(12)]
    [InlineData(6)]
    [InlineData(5.0)]    
    public void WithNambersInsideRange_GuardOutOfRange_ShouldNot_Throw(int input)
    {
        Assert.Equal(input, Guard.OutOfRange(input, 2, 12));
    }
}
