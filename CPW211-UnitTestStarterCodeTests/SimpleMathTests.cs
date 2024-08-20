using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            double expected = num1 + num2; //get expected sum of two parameters
            double actual = SimpleMath.Add(num1, num2); //call the method to get the sum
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(10, 10)]
        [DataRow(1, 3)]
        public void Multiply_TwoNumbers_ReturnsProduct(double num1, double num2)
        {
            // Use a few pairs of values to test the Multiply method
            double expected = num1 * num2; //expected parameters product
            double actual = SimpleMath.Multiply(num1, num2); // actual method result
            Assert.AreEqual(expected, actual);//Check if the results are equal
        }

        [TestMethod]
        [DataRow(5, 0)]
        [DataRow(10, 0)]
        [DataRow(100, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double num1, double num2)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentException>(() => SimpleMath.Divide(num1, num2));
        }

        // TODO: Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 5)]
        [DataRow(100, 5)]
        [DataRow(20, 5)]
        public void Divide_TwoNumbers_ReturnsQuotient(double num1, double num2)
        {
            double expected = num1 / num2; //expected quotient from the num1 and num2
            double actual = SimpleMath.Divide(num1, num2); //nethod call for num1 and num2
            Assert.AreEqual(expected, actual); //check if expected and actual are the same
        }
        // TODO: Test subtract method with two valid numbers
        [TestMethod]
        [DataRow(5, 5)]
        [DataRow(10, 5)]
        [DataRow(100, 5)]
        [DataRow(47, 35)]
        public void Subtract_TwoNumbers_ReturnsDifference(double num1, double num2)
        {
            double expected = num1 - num2; //subtract dataRow parameters
            double actual = SimpleMath.Subtract(num1, num2); //use method to process datarow
            Assert.AreEqual(expected, actual); //compare expected and actual for results
        }
    }
}