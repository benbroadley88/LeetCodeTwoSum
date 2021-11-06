using System;
using System.Runtime.CompilerServices;

namespace TwoSum
{
    public class TwoSum
    {
        internal static int MAX_INPUT = Convert.ToInt32(Math.Pow(10, 9));
        internal static int MIN_INPUT = Convert.ToInt32(Math.Pow(-10, 9));

        internal static int MAX_TARGET = Convert.ToInt32(Math.Pow(10, 9));
        internal static int MIN_TARGET = Convert.ToInt32(Math.Pow(-10, 9));

        static void Main(string[] args)
        {
        }

        public static int[] Calculate(int[] input, int target)
        {
            if (!InputIsValid(input))
            {
                throw new ArgumentException("The input parameter does not meet the conditions of the challenge");
            }

            if (!TargetIsValid(target))
            {
                throw new ArgumentException("The taget parameter does not meet the conditions of the challenge");
            }

            for (var i = 0; i < input.Length; i++)
            {
                for (var j = 0; j < input.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (input[i] + input[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            throw new ArgumentException("The inputs contained no valid solution");
        }

        internal static bool TargetIsValid(int target)
        {
            return target >= MIN_TARGET && target <= MAX_TARGET;
        }

        internal static bool InputIsValid(int[] input)
        {
            if (input.Length < 2 || input.Length > 104)
            {
                return false;
            }

            foreach (var inputValue in input)
            {
                if (inputValue < MIN_INPUT || inputValue > MAX_INPUT)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
