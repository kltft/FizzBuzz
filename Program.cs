using FizzBuzz;

NumberTranslatorService translateService = new NumberTranslatorService();
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine(translateService.TranslateFizzBuzz(i));
}
