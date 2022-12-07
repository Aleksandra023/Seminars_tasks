// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
string str = Console.ReadLine();
int number = int.Parse(str);

int first = number / 10;
int second = first % 10;
Console.WriteLine($"Вторая цифра: {second}");
