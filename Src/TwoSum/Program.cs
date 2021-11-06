using System;
using System.CommandLine;
using System.CommandLine.Invocation;

namespace TwoSum
{
    public class Program
    {
        public static int Main(string[] args)
        {
            var rootCommand = new RootCommand
            {
                new Option<int[]>("--numbers", "The integer array of input numbers."),
                new Option<int>("--target", "The target sum to find.")
            };

            rootCommand.Description = "LeetCode TwoSum implementation";

            rootCommand.Handler = CommandHandler.Create<int[], int>((numbers, target) =>
            {
                try
                {
                    var result = TwoSum.Calculate(numbers, target);
                    Console.WriteLine($"index {result[0]} and {result[1]} add to make {target}");

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
