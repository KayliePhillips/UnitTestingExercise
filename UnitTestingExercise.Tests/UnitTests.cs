using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]    //Add test data <-------
        [InlineData(2, 2, 2, 6)]
        [InlineData(0, 1, -1, 0)]
        [InlineData(10, 10, 20, 40)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //DONE Start Step 3 here:

            //Arrange
            // create a Calculator object
            var numAdd = new Calculator();


            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = numAdd.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,10,0)]//Add test data <-------
        [InlineData(5,3,2)]
        [InlineData(25, 5, 20)]
        [InlineData(4, 10, -6)]
        [InlineData(100, 200, -100)]
        [InlineData(14, 4, 10)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var numSub = new Calculator();

            //Act
            var actual = numSub.Sub(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Theory]
        [InlineData(10,10, 100)] //Add test data <-------
        [InlineData(5,2,10)]
        [InlineData(2,2,4)]
        [InlineData(4,-10, -40)]
        [InlineData(3,4,12)]
        [InlineData(-3, -3, 9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var numMultiply = new Calculator();

            //Act
            var actual = numMultiply.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }



        [Theory]
        [InlineData(20,5, 4)]//Add test data <-------
        [InlineData(-10,2, -5)]
        [InlineData(3, 1, 3)]
        [InlineData(0, 100, 0)]
        [InlineData(30,10,3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var numDivide = new Calculator();

            //Act
            var actual = numDivide.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
