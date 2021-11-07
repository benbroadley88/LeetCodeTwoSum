using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSumII.Tests
{
    [TestClass]
    public class ExampleTests
    {
        private TwoSumII mInstance;

        [TestInitialize]
        public void TestInitialize()
        {
            mInstance = new TwoSumII();
        }

        /// <summary>
        /// **Example 1:**
        /// ```
        /// Input: numbers = [2,7,11,15], target = 9
        /// Output: [1,2]
        ///         
        /// Explanation: The sum of 2 and 7 is 9. Therefore, index1 = 1, index2 = 2. We return [1, 2].
        /// ```
        /// </summary>
        [TestMethod]
        public void Example1()
        {
            var numbers = new int[] { 2, 7, 11, 15 };
            var target = 9;

            var result = mInstance.Calculate(numbers, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        /// **Example 2:**
        /// ```
        /// Input: numbers = [2,3,4], target = 6
        /// Output: [1,3]
        ///         
        /// Explanation: The sum of 2 and 4 is 6. Therefore index1 = 1, index2 = 3. We return [1, 3].
        /// ```
        [TestMethod]
        public void Example2()
        {
            var numbers = new int[] { 2, 3, 4 };
            var target = 6;

            var result = mInstance.Calculate(numbers, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
        }

        /// ***Example 3:***
        /// ```
        /// Input: numbers = [-1,0], target = -1
        /// Output: [1,2]
        ///         
        /// Explanation: The sum of -1 and 0 is -1. Therefore index1 = 1, index2 = 2. We return [1, 2].
        /// ```
        [TestMethod]
        public void Example3()
        {
            var numbers = new int[] { -1, 0 };
            var target = -1;

            var result = mInstance.Calculate(numbers, target);

            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
        }
    }
}