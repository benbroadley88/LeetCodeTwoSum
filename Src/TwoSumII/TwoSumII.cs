using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSumII
{
    public class TwoSumII
    {
        private const int NUMBERS_MIN_LENGTH = 2;
        private static int NUMBERS_MAX_LENGTH = Convert.ToInt32(3* Math.Pow(10, 4));

        private const int NUMBERS_VALUE_LOWER_LIMIT = -1000;
        private const int NUMBERS_VALUE_UPPER_LIMIT = 1000;

        private const int TARGET_UPPER_LIMIT = 1000;
        private const int TARGET_LOWER_LIMIT = -1000;

        #region Input Validation

        internal static bool ValidateNumbers(int[] numbers)
        {
            if (numbers.Length >= NUMBERS_MIN_LENGTH && numbers.Length <= NUMBERS_MAX_LENGTH)
            {
                return !numbers.Any(num => num < NUMBERS_VALUE_LOWER_LIMIT || num > NUMBERS_VALUE_UPPER_LIMIT);
            }

            return false;
        }

        internal static bool ValidateTarget(int target)
        {
            return target >= TARGET_LOWER_LIMIT && target <= TARGET_UPPER_LIMIT;
        }

        #endregion

        #region Challenge Calculation 

        public int[] Calculate(int[] numbers, int target)
        {
            var result = new int[2];

            return result;
        }

        #endregion
    }
}
