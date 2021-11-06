using System;
using System.Linq;

namespace TwoSum
{
    public class TwoSum
    {
        internal static int MAX_LENGTH = Convert.ToInt32(Math.Pow(10, 4));

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
                throw new ArgumentException(LocalizedResources.InvalidInputParameter);
            }

            if (!TargetIsValid(target))
            {
                throw new ArgumentException(LocalizedResources.InvalidTargetParameter);
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

            throw new ArgumentException(LocalizedResources.NoSolutionError);
        }

        internal static bool TargetIsValid(int target)
        {
            return target >= MIN_TARGET && target <= MAX_TARGET;
        }

        internal static bool InputIsValid(int[] input)
        {
            if (input.Length >= 2 && input.Length <= MAX_LENGTH)
            {
                return input.All(inputValue => inputValue >= MIN_INPUT && inputValue <= MAX_INPUT);
            }

            return false;
        }
    }
}
