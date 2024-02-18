using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class RepeatStringsTests
{
    [Test]
    public void Test_Repeat_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = RepeatStrings.Repeat(input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Repeat_SingleInputString_ReturnsRepeatedString()
    {
        //Arrange
        string[] input = new string[] { "Naomi" };

        //Act
        string actual = RepeatStrings.Repeat(input);
        string expected = "NaomiNaomiNaomiNaomiNaomi";

        //Assert

        Assert.AreEqual(expected, actual);


    }

    [Test]
    public void Test_Repeat_MultipleInputStrings_ReturnsConcatenatedRepeatedStrings()
    {
        //Arrange
        string[] input = new string[] { "Naomi", "InTheMix", "Milk" };

        //Act
        string actual = RepeatStrings.Repeat(input);
        string expected = "NaomiNaomiNaomiNaomiNaomiInTheMixInTheMixInTheMixInTheMixInTheMixInTheMixInTheMixInTheMixMilkMilkMilkMilk";

        //Assert

        Assert.AreEqual(expected, actual);

    }
}
