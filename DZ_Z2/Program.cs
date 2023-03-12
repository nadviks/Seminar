// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine()!);
if (A > B)
{
    int max = A;
    Console.WriteLine($"max = {A}");
}
else if (B > A)
{
    int max = B;
    Console.WriteLine($"max = {B}");
}
else 
{
    Console.WriteLine($"Числа равны {A} = {B}");
}