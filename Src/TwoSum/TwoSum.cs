using System;
using System.ComponentModel.DataAnnotations;

namespace TwoSum
{
    public class TwoSum
    {
        static void Main(string[] args)
        {
        }

        public static int[] Calculate(int[] input, int target)
        {
            if (!ValidateInput(input))
            {
                throw new ArgumentException("The input parameter does not meet the conditions of the challenge");
            }

            if (!ValidateTarget(target))
            {
                throw new ArgumentException("The taget parameter does not meet the conditions of the challenge");
            }

            var result = new int[2];

            return result;
        }

        private static bool ValidateTarget(int target)
        {
            return target < -110 || target > 110;
        }

        private static bool ValidateInput(int[] input)
        {
            if (input.Length < 2 || input.Length > 104)
            {
                return false;
            }

            foreach (var inputValue in input)
            {
                if (inputValue < -109 || inputValue > 109)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
