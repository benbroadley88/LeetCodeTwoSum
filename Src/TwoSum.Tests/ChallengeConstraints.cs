using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TwoSum.Tests
{
    [TestClass]
    public class ChallengeConstraints
    {
        #region Constraint 1

        [TestMethod]
        public void Constraint1_ValidCases()
        {
            const int MIN_LENGTH = 2;
            var minLengthArray = new int[MIN_LENGTH];

            for (var i = 0; i < minLengthArray.Length; i++)
            {
                minLengthArray[i] = new Random().Next(TwoSum.MIN_INPUT, TwoSum.MAX_INPUT);
            }

            var maxLengthArray = new int[TwoSum.MAX_LENGTH];
            for (var i = 0; i < maxLengthArray.Length; i++)
            {
                maxLengthArray[i] = new Random().Next(TwoSum.MIN_INPUT, TwoSum.MAX_INPUT);
            }

            Assert.IsTrue(TwoSum.InputIsValid(minLengthArray));
            Assert.IsTrue(TwoSum.InputIsValid(maxLengthArray));
        }

        /// <summary>
        /// Constraint 1:
        /// 2 <= nums.length <= 10^4
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint1_LowerLimit_Throws()
        {
            try
            {
                var input = new int[1] { 1 };
                var target = 0;

                var result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.InvalidInputParameter, e.Message);
                throw;
            }
        }

        [TestMethod]
        public void Constraint1_LowerLimit_Validate()
        {
            var input = new int[1] { 1 };

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        /// <summary>
        /// Constraint 1:
        /// 2 <= nums.length <= 10^4
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint1_UpperLimit_Throws()
        {
            try
            {
                var input = new int[TwoSum.MAX_LENGTH + 1];
                var target = 0;

                var result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.InvalidInputParameter, e.Message);
                throw;
            }
        }

        [TestMethod]
        public void Constraint1_UpperLimit_Validate()
        {
            var input = new int[1] { 1 };

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        #endregion

        #region Constraint 2

        [TestMethod]
        public void Constraint2_ValidCases()
        {
            var arrayInput = new int[TwoSum.MAX_LENGTH];

            Array.Fill(arrayInput, TwoSum.MIN_INPUT);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, -50);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, 0);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, 50);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));

            Array.Fill(arrayInput, TwoSum.MAX_INPUT);
            Assert.IsTrue(TwoSum.InputIsValid(arrayInput));
        }

        /// <summary>
        /// Constraint 2:
        /// -10^9 <= nums[i] <= 10^9
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint2_LowerLimit_Throws()
        {
            try
            {
                var input = new int[TwoSum.MAX_LENGTH];
                Array.Fill(input, TwoSum.MIN_INPUT - 1);
                var target = 0;
                var result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.InvalidInputParameter, e.Message);
                throw;
            }
        }

        [TestMethod]
        public void Constraint2_LowerLimit_Validate()
        {
            var input = new int[TwoSum.MAX_LENGTH];
            Array.Fill(input, TwoSum.MIN_INPUT - 1);

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        /// <summary>
        /// Constraint 2:
        /// -10^9 <= nums[i] <= 10^9
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint2_UpperLimit_Throws()
        {
            try
            {
                var input = new int[TwoSum.MAX_LENGTH];
                Array.Fill(input, TwoSum.MAX_INPUT + 1);
                var target = 0;
                var result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.InvalidInputParameter, e.Message);
                throw;
            }
        }

        [TestMethod]
        public void Constraint2_UpperLimit_Validate_Throws()
        {
            var input = new int[TwoSum.MAX_LENGTH];
            Array.Fill(input, TwoSum.MAX_INPUT + 1);

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        [TestMethod]
        public void Constraint2_UpperLimit_ValidateSingle()
        {
            // Fill the array with mid-range values
            var input = new int[TwoSum.MAX_LENGTH];
            Array.Fill(input, 0);

            // Include just one, in a random position in the array that's out of the permitted range.
            input[10] = TwoSum.MAX_INPUT + 1;

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        [TestMethod]
        public void Constraint2_LowerLimit_ValidateSingle()
        {
            // Fill the array with mid-range values
            var input = new int[TwoSum.MAX_LENGTH];
            Array.Fill(input, 0);

            // Include just one, in a random position in the array that's out of the permitted range.
            input[10] = TwoSum.MIN_INPUT - 1;

            Assert.IsFalse(TwoSum.InputIsValid(input));
        }

        #endregion

        #region Constraint 3 

        [TestMethod]
        public void Constraint3_ValidCases()
        {
            Assert.IsTrue(TwoSum.TargetIsValid(TwoSum.MAX_INPUT));
            Assert.IsTrue(TwoSum.TargetIsValid(25));
            Assert.IsTrue(TwoSum.TargetIsValid(0));
            Assert.IsTrue(TwoSum.TargetIsValid(-25));
            Assert.IsTrue(TwoSum.TargetIsValid(TwoSum.MIN_INPUT));
        }

        /// <summary>
        /// Constraint 3:
        /// -10^9 <= target <= 10^9
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint3_LowerLimit_Throws()
        {
            try
            {
                var input = new int[] { 0, 0 };
                var target = TwoSum.MIN_TARGET - 1;

                var result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.InvalidTargetParameter, e.Message);
                throw;
            }
        }

        [TestMethod]
        public void Constraint3_LowerLimit_Validate()
        {
            var target = TwoSum.MIN_TARGET - 1;

            Assert.IsFalse(TwoSum.TargetIsValid(target));
        }

        /// <summary>
        /// Constraint 3:
        /// -10^9 <= target <= 10^9
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constraint3_UpperLimit_Throws()
        {
            try
            {
                var input = new int[] { 0, 0 };
                var target = TwoSum.MAX_TARGET + 1;
                var result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.InvalidTargetParameter, e.Message);
                throw;
            }
        }

        [TestMethod]
        public void Constraint3_UpperLimit_Validate()
        {
            var target = TwoSum.MAX_TARGET + 1;
            Assert.IsFalse(TwoSum.TargetIsValid(target));
        }

        #endregion

        #region Miscellaneous

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ThrowsWhenNoSolutionFound()
        {
            try
            {
                var input = new int[] { 2, 3, 4 };
                var target = 99;

                int[] result = TwoSum.Calculate(input, target);
            }
            catch (ArgumentException e)
            {
                Assert.AreEqual(LocalizedResources.NoSolutionError, e.Message);
                throw;
            }
        }

        #endregion
    }
}