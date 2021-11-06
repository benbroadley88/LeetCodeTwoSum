using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass]
    public class ChallengeConstraints
    {
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

            var result = TwoSum.Calculate(input, target);
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

            var result = TwoSum.Calculate(input, target);
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

            var result = TwoSum.Calculate(input, target);
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

            var result = TwoSum.Calculate(input, target);
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

            var result = TwoSum.Calculate(input, target);
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

            var result = TwoSum.Calculate(input, target);
        }
    }
}
