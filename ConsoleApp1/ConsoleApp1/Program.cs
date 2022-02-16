// See https://aka.ms/new-console-template for more information


using POOConcepts;

Console.WriteLine("POO Concepts");
Console.WriteLine("============");

try
{
    Console.WriteLine(new Date(2022, 2, 10));
    Console.WriteLine(new Date(1974, 12, 23));
    Console.WriteLine(new Date(2023, 11, 9));
    Console.WriteLine(new Date(2024, 2, 29));
}
catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}
