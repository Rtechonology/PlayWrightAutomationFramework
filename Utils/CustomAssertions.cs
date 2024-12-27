using NUnit.Framework;
using NUnit.Framework.Legacy;

public static class CustomAssertions
{
    public static void AssertPageTitle(string actual, string expected)
    {
        ClassicAssert.AreEqual(expected, actual, "The page title does not match the expected value.");
    }
}
