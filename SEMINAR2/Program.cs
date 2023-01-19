// See https://aka.ms/new-console-template for more information
/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8 */


int InputInt(string message)
{
Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
return a;
}

int number = InputInt("введите трёхзначное число");
if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine($"Последняя цифра числа = {result}");
}
else 
{
Console.WriteLine("Число - не трёхзначное");
}
