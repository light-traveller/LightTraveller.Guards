using LightTraveller.Guards;
using static LightTraveller.Guards.Messages;

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
        Assert.StartsWith(string.Format(IntegerZero, nameof(zeroInt)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroLong));
        Assert.StartsWith(string.Format(LongZero, nameof(zeroLong)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroFloat));
        Assert.StartsWith(string.Format(FloatZero, nameof(zeroFloat)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroDouble));
        Assert.StartsWith(string.Format(DoubleZero, nameof(zeroDouble)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Zero(zeroDecimal));
        Assert.StartsWith(string.Format(DecimalZero, nameof(zeroDecimal)), exception.Message, StringComparison.InvariantCulture);
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
        Assert.StartsWith(string.Format(IntegerNegative, nameof(negInt)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negLong));
        Assert.StartsWith(string.Format(LongNegative, nameof(negLong)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negFloat));
        Assert.StartsWith(string.Format(FloatNegative, nameof(negFloat)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negDouble));
        Assert.StartsWith(string.Format(DoubleNegative, nameof(negDouble)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Negative(negDecimal));
        Assert.StartsWith(string.Format(DecimalNegative, nameof(negDecimal)), exception.Message, StringComparison.InvariantCulture);
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
        Assert.StartsWith(string.Format(IntegerZeroOrNegative, nameof(input)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(longInput));
        Assert.StartsWith(string.Format(LongZeroOrNegative, nameof(longInput)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(floatInput));
        Assert.StartsWith(string.Format(FloatZeroOrNegative, nameof(floatInput)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(doubleInput));
        Assert.StartsWith(string.Format(DoubleZeroOrNegative, nameof(doubleInput)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrNegative(decimalInput));
        Assert.StartsWith(string.Format(DecimalZeroOrNegative, nameof(decimalInput)), exception.Message, StringComparison.InvariantCulture);
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
        Assert.StartsWith(string.Format(IntegerPositive, nameof(posInt)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posLong));
        Assert.StartsWith(string.Format(LongPositive, nameof(posLong)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posFloat));
        Assert.StartsWith(string.Format(FloatPositive, nameof(posFloat)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posDouble));
        Assert.StartsWith(string.Format(DoublePositive, nameof(posDouble)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.Positive(posDecimal));
        Assert.StartsWith(string.Format(DecimalPositive, nameof(posDecimal)), exception.Message, StringComparison.InvariantCulture);
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
        Assert.StartsWith(string.Format(IntegerZeroOrPositive, nameof(input)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(longInput));
        Assert.StartsWith(string.Format(LongZeroOrPositive, nameof(longInput)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(floatInput));
        Assert.StartsWith(string.Format(FloatZeroOrPositive, nameof(floatInput)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(doubleInput));
        Assert.StartsWith(string.Format(DoubleZeroOrPositive, nameof(doubleInput)), exception.Message, StringComparison.InvariantCulture);

        exception = Assert.Throws<ArgumentException>(() => _ = Guard.ZeroOrPositive(decimalInput));
        Assert.StartsWith(string.Format(DecimalZeroOrPositive, nameof(decimalInput)), exception.Message, StringComparison.InvariantCulture);
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
}
