// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Write("n = ");
int n = int.Parse(Console.ReadLine());
int a = 1;
while (a <= n)
{
    int cub = a * a * a;
    a = a + 1;
    Console.Write($"{cub} ");
}