namespace LightTraveller.Guards.UnitTests;
internal class TestHelpers
{
    internal const string CUSTOM_MESSAGE = "My custom exception message.";
    internal const string EXPECTED_MESSAGE_TEMPLATE = CUSTOM_MESSAGE + " (Parameter '{0}')";
    internal static string GetMessage(string message, string paramName) => message + $" (Parameter '{paramName}')";
    internal static string GetCustomMessage(string paramName) => string.Format(EXPECTED_MESSAGE_TEMPLATE, paramName);
}
