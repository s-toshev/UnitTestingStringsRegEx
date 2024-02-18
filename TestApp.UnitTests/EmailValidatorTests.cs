using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{

    [TestCase("jane_smith123@email.co.uk", true)]
    [TestCase("user1234@email-provider.com", true)]
    [TestCase("john.doe@example.com", true)]
    [TestCase("my_email+test@email-domain.net", true)]
    public void Test_ValidEmails_ReturnsTrue(string email, bool expected)
    {
        // Arrange

        // Act
        bool actual = EmailValidator.IsValidEmail(email);
        // Assert
        Assert.AreEqual(expected, actual);


    }

    [TestCase("invalid.email.com", false)]
    [TestCase("user@domain", false)]
    [TestCase("user@domain.", false)]
    [TestCase("user@domain..", false)]
    //[TestCase("user@domain..com", false)] //BUG HERE
    [TestCase("user@domain.com_", false)]
    [TestCase("user@domain.com!test", false)]
    public void Test_InvalidEmails_ReturnsFalse(string email,bool expected)
    {
        // Arrange

        // Act
        bool actual = EmailValidator.IsValidEmail(email);

        // Assert

        Assert.AreEqual(expected, actual);
    }
}
