// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7:");
string str = Console.ReadLine();
int number = int.Parse(str);

if (number >= 1 && number <= 5)
{
    Console.WriteLine("будний день");
}
if (number <= 7 && number >= 6)
{
    Console.WriteLine("выходной день");
}