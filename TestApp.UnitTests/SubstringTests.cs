using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    // TODO: finish the test
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "mix";
        string input = "The quick brown mix fox jumps over the lazy dog";

        // Act
        string actual = Substring.RemoveOccurrences(toRemove, input);
        string expected = "The quick brown fox jumps over the lazy dog";


        // Assert
        Assert.AreEqual(expected, actual);

    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        //Arrange
        string toRemove = "Quickly";
        string text = "Quickly discovering that the name Naomi spelled backwards yields 'I moan' added an unexpected twist to our conversation.";

        //Act
        string actual = Substring.RemoveOccurrences(toRemove, text);
        string expected = "discovering that the name Naomi spelled backwards yields 'I moan' added an unexpected twist to our conversation.";
        //Assert
        Assert.AreEqual (expected, actual);


    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        //Arrange
        string toRemove = ".";
        string text = "Realizing the palindrome in Naomi's name, 'I moan,' sparked a playful exchange among friends.";

        //Act
        string actual = Substring.RemoveOccurrences(toRemove, text);
        string expected = "Realizing the palindrome in Naomi's name, 'I moan,' sparked a playful exchange among friends";
        //Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        //Arrange
        string toRemove = "Naomi";
        string text = "Realizing the palindrome in Naomi's name, 'I moan,' sparked a playful exchange among friends. Quickly discovering that the name Naomi spelled backwards yields 'I moan' added an unexpected twist to our conversation.";

        //Act
        string actual = Substring.RemoveOccurrences(toRemove, text);
        string expected = "Realizing the palindrome in 's name, 'I moan,' sparked a playful exchange among friends. Quickly discovering that the name spelled backwards yields 'I moan' added an unexpected twist to our conversation.";
        //Assert
        Assert.AreEqual(expected, actual);
    }
}
