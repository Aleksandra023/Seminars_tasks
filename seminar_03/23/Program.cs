// // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// // 3 -> 1, 8, 27
// // 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
double num = double.Parse(Console.ReadLine());
Console.WriteLine();

for (int a = 1; a <= num; a++)
{
    double x = Math.Pow(a, 3);
    Console.Write(x + " ");
}