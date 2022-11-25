// // Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

Console.WriteLine("Введите число для проверки на четность");
string str = Console.ReadLine();
int number = int.Parse(str);

if (number % 2 == 0)
{
    Console.WriteLine();
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine();
    Console.WriteLine("Число НЕчетное");
}