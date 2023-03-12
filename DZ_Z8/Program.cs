// Задача 8: Напишите программу, которая на вход принимает 
// число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int k = 1;

while (k < (n+1))
{
    if (k % 2 == 0)
    {
        Console.Write($"{k} ");
    }
    k++;
}