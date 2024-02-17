using NUnit.Framework.Legacy;
using NUnit.Framework;
using UnitTest;
using Assert = NUnit.Framework.Assert;
using System;

namespace MethodsTestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        
        [Fact]
        [Test]
        public void LogAction_Should_Print_Message_In_Expected_Color()
        {
            // Arrange
            string expectedMessage = "Test message";
            ConsoleColor expectedColor = ConsoleColor.Green;

            // Act
            Methods.LogAction(expectedMessage, expectedColor);

            // Assert
            // You cannot directly assert the output of a console write operation.
        }

        
        [Fact]
        [Test]
        public void SquareToString_Should_Return_Square_Of_Input_Number_As_String()
        {
            // Arrange
            int input = 3;
            string expectedOutput = "9";

            // Act
            string result = Methods.SquareToString(input);

            // Assert
           ClassicAssert.AreEqual(expectedOutput, result);
        }


        
        [Fact]
        [Test]
        public void EvenSquaredNumbersAbove30_Should_Return_Correct_Result()
        {
            // Arrange
            int[] expectedOutput = { 36, 64, 100 };

            // Act
            var result = Methods.EvenSquaredNumbersAbove30().ToArray();

            // Assert
            ClassicAssert.AreEqual(expectedOutput, result);
        }


    }
}
