using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:
            
            //Arrange
            
            // create a Calculator object
            var test = new Calculator();
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
              var actual = test.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(7,3,4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var testSub = new Calculator();

            //Act
            var actual = testSub.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,3,6)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var testProd = new Calculator();
            //Act
            var actual = testProd.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,2,4)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var testDiv = new Calculator();
            //Act
            var actual = testDiv.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
