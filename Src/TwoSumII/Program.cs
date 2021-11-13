using System;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace TwoSumII
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var numbersOption = new Option<int[]>("--numbers", "The integer array of input numbers.") { IsRequired = true };
            var targetOption = new Option<int>("--target", "The target sum to find.") { IsRequired = true };

            var rootCommand = new RootCommand { numbersOption, targetOption };

            rootCommand.Description = "LeetCode TwoSum implementation";

            rootCommand.Handler = CommandHandler.Create<int[], int>((numbers, target) =>
            {
                try
                {
                    var twoSumProgram = new TwoSumII();
                    var result = twoSumProgram.Calculate(numbers, target);

                    Console.WriteLine($"The result is: [{result[0]}, {result[1]}]");

                    return 0;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    return 1;
                }
            });

            return rootCommand.InvokeAsync(args).Result;
        }
    }
}