using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSumII.Tests
{
    [TestClass]
    public class ConstraintTests
    {
        #region Constraint 1

        /// <summary>
        /// 2 <= numbers.length <= 3 * 10^4
        /// </summary>
        [TestMethod]
        public void Constraint1_ValidCases()
        {
            var minLength = 2;
            Assert.IsTrue(TwoSumII.ValidateNumbers(new int[minLength]));

            var maxLength = Convert.ToInt32(Math.Pow(10, 4)) * 3;
            Assert.IsTrue(TwoSumII.ValidateNumbers(new int[maxLength]));
        }

        /// <summary>
        /// 2 <= numbers.length <= 3 * 10^4
        /// </summary>
        [TestMethod]
        public void Constraint1_InvalidCases()
        {
            var minLength = 2;
            Assert.IsFalse(TwoSumII.ValidateNumbers(new int[minLength - 1]));

            var maxLength = Convert.ToInt32(Math.Pow(10, 4)) * 3;
            Assert.IsFalse(TwoSumII.ValidateNumbers(new int[maxLength + 1]));
        }

        #endregion

        #region Constraint 2 

        /// <summary>
        /// -1000 <= numbers[i] <= 1000
        /// </summary>
        [TestMethod]
        public void Constraint2_ValidCases()
        {
            var lowerLimit = -1000;
            var upperLimit = 1000;

            var lowerLimitArray = new int[50];
            Array.Fill(lowerLimitArray, lowerLimit);

            var upperLimitArray = new int[50];
            Array.Fill(upperLimitArray, upperLimit);

            var mixedArray = new int[50];
            for (var i = 0; i < mixedArray.Length; i++)
            {
                mixedArray[i] = new Random().Next(lowerLimit, upperLimit);
            }

            Assert.IsTrue(TwoSumII.ValidateNumbers(lowerLimitArray));
            Assert.IsTrue(TwoSumII.ValidateNumbers(upperLimitArray));
            Assert.IsTrue(TwoSumII.ValidateNumbers(mixedArray));
        }

        /// <summary>
        /// -1000 <= numbers[i] <= 1000
        /// </summary>
        [TestMethod]
        public void Constraint2_InvalidCases_AllOutOfRange()
        {
            var lowerLimit = -1000;
            var upperLimit = 1000;

            var lowerLimitArray = new int[50];
            Array.Fill(lowerLimitArray, lowerLimit - 1);

            var upperLimitArray = new int[50];
            Array.Fill(upperLimitArray, upperLimit + 1);

            Assert.IsFalse(TwoSumII.ValidateNumbers(lowerLimitArray));
            Assert.IsFalse(TwoSumII.ValidateNumbers(upperLimitArray));
        }

        /// <summary>
        /// -1000 <= numbers[i] <= 1000
        /// </summary>
        [TestMethod]
        public void Constraint2_InvalidCases_SingleValueOutOfRange()
        {
            var lowerLimit = -1000;
            var upperLimit = 1000;

            var array = new int[50];
            
            // Fill the array with valid values
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(lowerLimit, upperLimit);
            }

            // Change one, at a random position such that it does not meet the criteria
            array[25] = upperLimit * 2;

            Assert.IsFalse(TwoSumII.ValidateNumbers(array));
        }

        #endregion

        #region Constraint 4 

        /// <summary>
        /// `-1000 <= target <= 1000`
        /// </summary>
        [TestMethod]
        public void Constraint4_ValidCases()
        {
            Assert.IsTrue(TwoSumII.ValidateTarget(-1000));
            Assert.IsTrue(TwoSumII.ValidateTarget(-500));
            Assert.IsTrue(TwoSumII.ValidateTarget(0));
            Assert.IsTrue(TwoSumII.ValidateTarget(500));
            Assert.IsTrue(TwoSumII.ValidateTarget(1000));
        }


        /// <summary>
        /// `-1000 <= target <= 1000`
        /// </summary>
        [TestMethod]
        public void Constraint4_InvalidCases()
        {
            Assert.IsFalse(TwoSumII.ValidateTarget(-1001));
            Assert.IsFalse(TwoSumII.ValidateTarget(1001));
        }

        #endregion
    }
}