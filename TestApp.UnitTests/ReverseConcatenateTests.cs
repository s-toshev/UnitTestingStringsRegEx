using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    // TODO: finish the test

    [TestCase(new string[] { },"")] // Empty array
    [TestCase(null, "")] // Null array
    public void Test_ReverseAndConcatenateStrings_EmptyInputOrNullInput_ReturnsEmptyString(string[] input, string expected)
    {
        // Arrange

        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);    
        
        // Assert
        Assert.IsTrue(actual == expected);

    }

    // TODO: finish the test
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new string[] {"NaomI" };
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expected = "NaomI";
        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "NaomI","kravO","miX" };
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expected = "miXkravONaomI";
        // Assert

        Assert.AreEqual(expected, actual);
    }


    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "  ", "   ", "    " };
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expected = "         ";
        // Assert

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "NaomI", "kravO", "Discovering that the name Naomi spelled backwards yields 'I moan' added an unexpected twist to our conversation." };
        // Act
        string actual = ReverseConcatenate.ReverseAndConcatenateStrings(input);
        string expected = "Discovering that the name Naomi spelled backwards yields 'I moan' added an unexpected twist to our conversation.kravONaomI";
        // Assert

        Assert.AreEqual(expected, actual);
    }
}
