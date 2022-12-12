// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Ведите число ");
int n = int.Parse(Console.ReadLine());
int first = n / 10000;
Console.WriteLine(first);

int second = (n / 1000) % 10;
Console.WriteLine(second);

int fourth = (n / 10) % 10;
Console.WriteLine(fourth);

int fifth = n % 10;
Console.WriteLine(fifth);

if (first == fifth && second == fourth)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}