using NUnit.Framework;

namespace TestApp.UnitTests;

public class MatchPhoneNumbersTests
{
    // TODO: finish the test
    [Test]
    public void Test_Match_ValidPhoneNumbers_ReturnsMatchedNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        // Assert
        Assert.AreEqual(expected, actual);
    }

    [TestCase("088434534, +359894494431, +359-2-312-11", "")]
    [TestCase("", "")]
    public void Test_Match_NoValidPhoneNumbersOrEmptyInput_ReturnsEmptyString(string phoneNumbers, string expected)
    {
        //Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);


        //Assert
        Assert.AreEqual(expected, actual);


    }



    [Test]
    public void Test_Match_MixedValidAndInvalidNumbers_ReturnsOnlyValidNumbers()
    {
        // Arrange
        string phoneNumbers = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555, 088434534, +359894494431, +359-2-312-11";

        // Act
        string actual = MatchPhoneNumbers.Match(phoneNumbers);
        string expected = "+359-2-124-5678, +359 2 986 5432, +359-2-555-5555";
        // Assert
        Assert.AreEqual(expected, actual);
    }
}
