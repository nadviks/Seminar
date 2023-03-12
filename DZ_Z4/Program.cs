// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.
Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
Console.Write("Введите число C: ");
int C = int.Parse(Console.ReadLine()!);
int max = A;
if (B > A)
{
    max = B;
}
else if (C > B)
{
    max = C;
}
Console.WriteLine($"Максимальное из чисел : {max}");