using System.ComponentModel;
using LightTraveller.Guards;

namespace LightTraveller.Guards.UnitTests;

public class GuardInvalidEnumTests
{
    private enum TestEnum { One = 1, Two, Three }

    [Fact]
    public void WithInvalidEnumValues_GuardInvalidEnumValues_Should_ThrowInvalidEnumArgumentException()
    {
        var value = 0;
        _ = Assert.Throws<InvalidEnumArgumentException>(() => _ = Guard.InvalidEnumValue((TestEnum)value));
        _ = Assert.Throws<InvalidEnumArgumentException>(() => _ = Guard.InvalidEnumValue<TestEnum>(value));
    }

    [Fact]
    public void WithValidEnumValues_GuardInvalidEnumValues_ShouldNot_Throw()
    {
        var intValue = 1;
        var enumValue = TestEnum.One;

        Assert.Equal(enumValue, Guard.InvalidEnumValue((TestEnum)intValue));
        Assert.Equal(enumValue, Guard.InvalidEnumValue(enumValue));
        Assert.Equal(intValue, Guard.InvalidEnumValue<TestEnum>(intValue));        
        Assert.Equal(intValue, Guard.InvalidEnumValue<TestEnum>((int)enumValue));
    }
}
