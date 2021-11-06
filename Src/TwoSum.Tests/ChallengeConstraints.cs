using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass]
    public class ChallengeConstraints
    {
        [TestMethod]
        public void Constraint1_ValidCases()
        {
            const int MIN_LENGTH = 2;
            const int MAX_LENGTH = 104;
            var minLengthArray = new int[MIN_LENGTH];
            var maxLengthArray = new int[MAX_LENGTH];

            Assert.IsTrue(TwoSum.InputIsValid(minLengthArray));
            Assert.IsTrue(TwoSum.InputIsValid(maxLengthArray));
        }

        /// <summary>
        /// Constraint 1:
        /// 2 <= nums.length <= 104
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint1_LowerLimit_Throws()
        {
            var input = new int[1] { 1 };
            var target = 0;

            var result = TwoSum.Calculate(input, target);
        }

        [TestMethod]
        public void Constraint1_LowerLimit_Validate()
        {
            var input = new int[1] { 1 };

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        /// <summary>
        /// Constraint 1:
        /// 2 <= nums.length <= 104
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint1_UpperLimit_Throws()
        {
            var input = new int[105];
            var target = 0;

            var result = TwoSum.Calculate(input, target);
        }

        [TestMethod]
        public void Constraint1_UpperLimit_Validate()
        {
            var input = new int[1] { 1 };

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        [TestMethod]
        public void Constraint2_ValidCases()
        {
            const int MAX_LENGTH = 104;
            var arrayInput = new int[MAX_LENGTH];

            Array.Fill(arrayInput, -109);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, -50);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, 0);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, 50);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, 109);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));
        }

        /// <summary>
        /// Constraint 2:
        /// -109 <= nums[i] <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint2_LowerLimit_Throws()
        {
            var input = new int[104];
            Array.Fill(input, -110);

            var target = 0;

            var result = TwoSum.Calculate(input, target);
        }

        [TestMethod]
        public void Constraint2_LowerLimit_Validate()
        {
            var input = new int[104];
            Array.Fill(input, -110);

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        /// <summary>
        /// Constraint 2:
        /// -109 <= nums[i] <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint2_UpperLimit_Throws()
        {
            var input = new int[104];
            Array.Fill(input, 110);

            var target = 0;

            var result = TwoSum.Calculate(input, target);
        }

        [TestMethod]
        public void Constraint2_UpperLimit_Validate_Throws()
        {
            var input = new int[104];
            Array.Fill(input, 110);

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        [TestMethod]
        public void Constraint3_ValidCases()
        {
            Assert.IsTrue(TwoSum.TargetIsValid(109));
            Assert.IsTrue(TwoSum.TargetIsValid(25));
            Assert.IsTrue(TwoSum.TargetIsValid(0));
            Assert.IsTrue(TwoSum.TargetIsValid(-25));
            Assert.IsTrue(TwoSum.TargetIsValid(-109));
        }

        /// <summary>
        /// Constraint 3:
        /// -109 <= target <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint3_LowerLimit_Throws()
        {
            var input = new int[] { 0, 0 };
            var target = -110;

            var result = TwoSum.Calculate(input, target);
        }

        [TestMethod]
        public void Constraint3_LowerLimit_Validate()
        {
            var target = -110;

            Assert.IsFalse(TwoSum.TargetIsValid(target));
        }

        /// <summary>
        /// Constraint 3:
        /// -109 <= target <= 109
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint3_UpperLimit_Throws()
        {
            var input = new int[] { 0, 0 };
            var target = 110;

            var result = TwoSum.Calculate(input, target);
        }

        [TestMethod] 
        public void Constraint3_UpperLimit_Validate()
        {
            var target = 110;
            Assert.IsFalse(TwoSum.TargetIsValid(target));
        }
    }
}
