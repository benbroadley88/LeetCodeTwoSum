using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Example 1:
        /// Input: nums = [2,7,11,15], target = 9
        /// Output: [0,1]
        /// Output: Because nums[0] + nums[1] == 9, we return [0, 1].
        /// </summary>
        [TestMethod]
        public void Example1()
        {
            var input = new int[] { 2, 7, 11, 15 };
            var target = 9;

            int[] result = TwoSum(input, target);

            Assert.AreEqual(2, result.Length, "The result has an incorrect array length");
            Assert.AreEqual(0, result[0], "result[0] should be 0 (i.e. the first index of the given array)");
            Assert.AreEqual(1, result[1], "result[1] should be 1 (i.e. the second index of the given array)");

            Assert.AreEqual(input[result[0]] + input[result[1]], target);
        }

        /// <summary>
        /// Example 2:
        /// Input: nums = [3,2,4], target = 6
        /// Output: [1,2]
        /// </summary>
        [TestMethod]
        public void Example2()
        {
            var input = new int[] { 3, 2, 4 };
            var target = 6;

            int[] result = TwoSum(input, target);

            Assert.AreEqual(2, result.Length, "The result has an incorrect array length");
            Assert.AreEqual(1, result[0], "result[0] should be 1 (i.e. the second index of the given array)");
            Assert.AreEqual(2, result[1], "result[1] should be 2 (i.e. the third index of the given array)");

            Assert.AreEqual(input[result[0]] + input[result[1]], target);
        }

        /// <summary>
        /// Example 3:
        /// Input: nums = [3,3], target = 6
        /// Output: [0,1]
        /// </summary>
        [TestMethod]
        public void Example3()
        {
            var input = new int[] { 3, 3 };
            var target = 6;

            int[] result = TwoSum(input, target);

            Assert.AreEqual(2, result.Length, "The result has an incorrect array length");
            Assert.AreEqual(0, result[0], "result[0] should be 1 (i.e. the first index of the given array)");
            Assert.AreEqual(1, result[1], "result[1] should be 2 (i.e. the second index of the given array)");

            Assert.AreEqual(input[result[0]] + input[result[1]], target);
        }

        /// <summary>
        /// Constraint 1:
        /// 2 <= nums.length <= 104
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint1_LowerLimit()
        {
            var input = new int[1] { 1 };
            var target = 0;

            var result = TwoSum(input, target);
        }

        /// <summary>
        /// Constraint 1:
        /// 2 <= nums.length <= 104
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint1_UpperLimit()
        {
            var input = new int[105];
            var target = 0;

            var result = TwoSum(input, target);
        }

        /// <summary>
        /// Constraint 2:
        /// -109 <= nums[i] <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint2_LowerLimit()
        {
            var input = new int[104];
            Array.Fill(input, -110);

            var target = 0;

            var result = TwoSum(input, target);
        }

        /// <summary>
        /// Constraint 2:
        /// -109 <= nums[i] <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint2_UpperLimit()
        {
            var input = new int[104];
            Array.Fill(input, 110);

            var target = 0;

            var result = TwoSum(input, target);
        }

        /// <summary>
        /// Constraint 3:
        /// -109 <= target <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint3_LowerLimit()
        {
            var input = new int[] { 0, 0 };
            var target = -110;

            var result = TwoSum(input, target);
        }

        /// <summary>
        /// Constraint 3:
        /// -109 <= target <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint3_UpperLimit()
        {
            var input = new int[] { 0, 0 };
            var target = 110;

            var result = TwoSum(input, target);
        }
    }
}