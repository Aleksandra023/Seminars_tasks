﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Не используя Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите степень:");
int b = int.Parse(Console.ReadLine());
int result = 1;

for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine();
Console.WriteLine($"Итого = {result}");