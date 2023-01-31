using static LightTraveller.Guards.Messages;
using static LightTraveller.Guards.UnitTests.TestHelpers;

namespace LightTraveller.Guards.UnitTests;

public class GuardNumericTests
{
    [Fact]
    public void WithZero_GuradZero_Should_ThrowArgumentException()
    {
        var zeroInt = 0;
        var zeroLong = (long)zeroInt;
        var zeroFloat = (float)zeroInt;
        var zeroDouble = (double)zeroInt;
        var zeroDecimal = (decimal)zeroInt;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroInt));
        Assert.Equal(GetMessage(Zero, nameof(zeroInt)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroLong));
        Assert.Equal(GetMessage(Zero, nameof(zeroLong)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroFloat));
        Assert.Equal(GetMessage(Zero, nameof(zeroFloat)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroDouble));
        Assert.Equal(GetMessage(Zero, nameof(zeroDouble)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroDecimal));
        Assert.Equal(GetMessage(Zero, nameof(zeroDecimal)), exception.Message);
    }

    [Fact]
    public void WithZeroAndCustomMessage_GuardZero_Should_ThrowArgumentExceptionWithCustomMessage()
    {
        var zeroInt = 0;
        var zeroLong = (long)zeroInt;
        var zeroFloat = (float)zeroInt;
        var zeroDouble = (double)zeroInt;
        var zeroDecimal = (decimal)zeroInt;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroInt, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(zeroInt)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroLong, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(zeroLong)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroFloat, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(zeroFloat)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroDouble, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(zeroDouble)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroDecimal, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(zeroDecimal)), exception.Message);
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(1)]
    public void WithNegativeOrPositiveNumbers_GuradZero_ShouldNot_Throw(int input)
    {
        Assert.Equal(input, Guard.Zero(input));
        Assert.Equal((long)input, Guard.Zero((long)input));
        Assert.Equal((float)input, Guard.Zero((float)input));
        Assert.Equal((double)input, Guard.Zero((double)input));
        Assert.Equal((decimal)input, Guard.Zero((decimal)input));
    }

    [Fact]
    public void WithNegativeNumbers_GuradNegative_Should_ThrowArgumentException()
    {
        var negInt = -1;
        var negLong = (long)negInt;
        var negFloat = (float)negInt;
        var negDouble = (double)negInt;
        var negDecimal = (decimal)negInt;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negInt));
        Assert.Equal(GetMessage(Negative, nameof(negInt)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negLong));
        Assert.Equal(GetMessage(Negative, nameof(negLong)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negFloat));
        Assert.Equal(GetMessage(Negative, nameof(negFloat)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negDouble));
        Assert.Equal(GetMessage(Negative, nameof(negDouble)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negDecimal));
        Assert.Equal(GetMessage(Negative, nameof(negDecimal)), exception.Message);
    }

    [Fact]
    public void WithNegativeNumbersAndCustomMessage_GuradNegative_Should_ThrowArgumentExceptionWithCustomMessage()
    {
        var negInt = -1;
        var negLong = (long)negInt;
        var negFloat = (float)negInt;
        var negDouble = (double)negInt;
        var negDecimal = (decimal)negInt;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negInt, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(negInt)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negLong, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(negLong)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negFloat, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(negFloat)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negDouble, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(negDouble)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negDecimal, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(negDecimal)), exception.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void WithZeroOrPositiveNumbers_GuradNegative_ShouldNot_Throw(int input)
    {
        Assert.Equal(input, Guard.Negative(input));
        Assert.Equal((long)input, Guard.Negative((long)input));
        Assert.Equal((float)input, Guard.Negative((float)input));
        Assert.Equal((double)input, Guard.Negative((double)input));
        Assert.Equal((decimal)input, Guard.Negative((decimal)input));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void WithZeroOrNegativeNumbers_GuradZeroOrNegative_Should_ThrowArgumentException(int input)
    {
        var longInput = (long)input;
        var floatInput = (float)input;
        var doubleInput = (double)input;
        var decimalInput = (decimal)input;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(input));
        Assert.Equal(GetMessage(ZeroOrNegative, nameof(input)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(longInput));
        Assert.Equal(GetMessage(ZeroOrNegative, nameof(longInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(floatInput));
        Assert.Equal(GetMessage(ZeroOrNegative, nameof(floatInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(doubleInput));
        Assert.Equal(GetMessage(ZeroOrNegative, nameof(doubleInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(decimalInput));
        Assert.Equal(GetMessage(ZeroOrNegative, nameof(decimalInput)), exception.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void WithZeroOrNegativeNumbersAndCustomMessage_GuradZeroOrNegative_Should_ThrowArgumentExceptionWithCustomMessage(int input)
    {
        var longInput = (long)input;
        var floatInput = (float)input;
        var doubleInput = (double)input;
        var decimalInput = (decimal)input;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(input, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(input)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(longInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(longInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(floatInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(floatInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(doubleInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(doubleInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(decimalInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(decimalInput)), exception.Message);
    }

    [Fact]
    public void WithPositiveNumbers_GuradZeroOrNegative_ShouldNot_Throw()
    {
        var input = 1;
        Assert.Equal(input, Guard.ZeroOrNegative(input));
        Assert.Equal((long)input, Guard.ZeroOrNegative((long)input));
        Assert.Equal((float)input, Guard.ZeroOrNegative((float)input));
        Assert.Equal((double)input, Guard.ZeroOrNegative((double)input));
        Assert.Equal((decimal)input, Guard.ZeroOrNegative((decimal)input));
    }

    [Fact]
    public void WithPositiveNumber_GuradPositive_Should_ThrowArgumentException()
    {
        var posInt = 1;
        var posLong = (long)posInt;
        var posFloat = (float)posInt;
        var posDouble = (double)posInt;
        var posDecimal = (decimal)posInt;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posInt));
        Assert.Equal(GetMessage(Positive, nameof(posInt)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posLong));
        Assert.Equal(GetMessage(Positive, nameof(posLong)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posFloat));
        Assert.Equal(GetMessage(Positive, nameof(posFloat)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posDouble));
        Assert.Equal(GetMessage(Positive, nameof(posDouble)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posDecimal));
        Assert.Equal(GetMessage(Positive, nameof(posDecimal)), exception.Message);
    }

    [Fact]
    public void WithPositiveNumberAndCustomMessage_GuradPositive_Should_ThrowArgumentExceptionWithCustomMessage()
    {
        var posInt = 1;
        var posLong = (long)posInt;
        var posFloat = (float)posInt;
        var posDouble = (double)posInt;
        var posDecimal = (decimal)posInt;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posInt, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(posInt)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posLong, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(posLong)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posFloat, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(posFloat)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posDouble, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(posDouble)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posDecimal, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(posDecimal)), exception.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void WithZeroOrNegativeNumbers_GuradPositive_ShouldNot_Throw(int input)
    {
        Assert.Equal(input, Guard.Positive(input));
        Assert.Equal((long)input, Guard.Positive((long)input));
        Assert.Equal((float)input, Guard.Positive((float)input));
        Assert.Equal((double)input, Guard.Positive((double)input));
        Assert.Equal((decimal)input, Guard.Positive((decimal)input));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void WithZeroOrPositiveNumber_GuradZeroOrPositive_Should_ThrowArgumentException(int input)
    {
        var longInput = (long)input;
        var floatInput = (float)input;
        var doubleInput = (double)input;
        var decimalInput = (decimal)input;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(input));
        Assert.Equal(GetMessage(ZeroOrPositive, nameof(input)) , exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(longInput));
        Assert.Equal(GetMessage(ZeroOrPositive, nameof(longInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(floatInput));
        Assert.Equal(GetMessage(ZeroOrPositive, nameof(floatInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(doubleInput));
        Assert.Equal(GetMessage(ZeroOrPositive, nameof(doubleInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(decimalInput));
        Assert.Equal(GetMessage(ZeroOrPositive, nameof(decimalInput)), exception.Message);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    public void WithZeroOrPositiveNumberAndCustomMessage_GuradZeroOrPositive_Should_ThrowArgumentExceptionWithCustomMessage(int input)
    {
        var longInput = (long)input;
        var floatInput = (float)input;
        var doubleInput = (double)input;
        var decimalInput = (decimal)input;

        var exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(input, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(input)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(longInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(longInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(floatInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(floatInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(doubleInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(doubleInput)), exception.Message);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(decimalInput, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(decimalInput)), exception.Message);
    }

    [Fact]
    public void WithNegativeNumbers_GuradZeroOrPositive_ShouldNot_Throw()
    {
        var input = -1;
        Assert.Equal(input, Guard.ZeroOrPositive(input));
        Assert.Equal((long)input, Guard.ZeroOrPositive((long)input));
        Assert.Equal((float)input, Guard.ZeroOrPositive((float)input));
        Assert.Equal((double)input, Guard.ZeroOrPositive((double)input));
        Assert.Equal((decimal)input, Guard.ZeroOrPositive((decimal)input));
    }

    [Fact]
    public void WithIntPtrZero_GuardZeroPointer_Should_ThrowArgumentException()
    {
        var input = IntPtr.Zero;
        var exception = Assert.Throws<ArgumentException>(() => Guard.ZeroPointer(input, CUSTOM_MESSAGE));
        Assert.Equal(GetCustomMessage(nameof(input)), exception.Message);
    }

    [Fact]
    public void WithNonZeroIntPtr_GuardZeroPointer_ShouldNot_Throw()
    {
        var input = new IntPtr(2);
        Assert.Equal(input, Guard.ZeroPointer(input));
    }
}
