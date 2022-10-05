using System;
using FizzBuzz.services;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to FizzBuzz");
        Console.WriteLine("I'll perform FizzBuzz over a range of integers");
        string[] arguments = new string[3];
        args = Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length; i++)
        {
            arguments[i] = args[i];
        }
        if (arguments.Length == 1)
        {
            Console.WriteLine("I didn't see any values passed to define a range, so let's use 1 to 100.");
            arguments = new[] { "exe", "1", "100" };
        }
        RangeTranslationService rangeService = new RangeTranslationService();
        int[] range = rangeService.ConvertStringToInteger(arguments[1], arguments[2]);
        Console.WriteLine("FizzBuzz Results:");
        FizzBuzzTranslatorService fizzBuzzService = new FizzBuzzTranslatorService();
        for (int i = range[0]; i <= range[1]; i++)
        {
            Console.WriteLine(fizzBuzzService.TranslateFizzBuzz(i));
        }
    }
}