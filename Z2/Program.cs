// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да  // a = 2, b = 10 -> нет 

Console.Clear();
Console.Write("Введите число a: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA == numberB * numberB)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}