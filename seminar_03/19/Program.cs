// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом 
//(т.е. число должно быть одинаковым при чтении слева направо и справа налево).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введи пятизначное число:");
string num = Console.ReadLine();

if  (num.Length == 5) 
{   
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine();
        Console.WriteLine($"{num} - палиндром");
    }
    else 
    {
        Console.WriteLine();
        Console.WriteLine("Это НЕ палиндром");
    }
}
else
{
    Console.WriteLine();
    Console.WriteLine("Поробуй ПЯТИЗНАЧНОЕ число");
}