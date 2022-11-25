// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите первое число:");
string str = Console.ReadLine();
int a = int.Parse(str);
Console.WriteLine("Введите второе число:");
string str2 = Console.ReadLine();
int b = int.Parse(str2);
Console.WriteLine("Введите третье число:");
string str3 = Console.ReadLine();
int c = int.Parse(str3);
if (a > c && a > b)
{
    Console.WriteLine();
    Console.WriteLine("Первое число максимальное = " + a);
}
if (b > a && b > c)
{
    Console.WriteLine();
    Console.WriteLine("Второе число максимальное  = " + b);
}
if (c > a && c > b)
{
    Console.WriteLine();
    Console.WriteLine("Третье число максимальное = " + c);
}