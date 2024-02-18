using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("inthemix",5, "iNtHeMiXiNtHeMiXiNtHeMiXiNtHeMiXiNtHeMiX")]
    [TestCase("inthemix", 1, "iNtHeMiX")]
    [TestCase("inthemix", 2, "iNtHeMiXiNtHeMiX")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string actual = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert

        Assert.That(actual, Is.EqualTo(expected));
    }

    [TestCase("",1)]
   
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException(string input,
        int repetitionFactor)
    {
        
        //Act&Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input,repetitionFactor));


    }

    [TestCase("inthemix", -1)]
    [TestCase("inthemix", 0)]
    public void Test_GeneratePatternedString_NegativeOrZeroRepetitionFactor_ThrowsArgumentException(string input,
        int repetitionFactor)
    {
        // Act
        var exceptionActualMessage = Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));

        // Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetitionFactor));

        string expectedExceptionMsg = "Input string cannot be empty, and repetition factor must be positive.";

        Assert.That(exceptionActualMessage.Message, Is.EqualTo(expectedExceptionMsg));

    }


}
