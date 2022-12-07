// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[5];

for (int i = 0; i < array.Length; i++) // заполнение массива
{
    double number = new Random().Next(1, 1000) + new Random().NextDouble(); // целое + дробная часть
    array[i] = Math.Round(number, 2); // округление числа
    Console.Write(array[i] + " " );
}
Console.WriteLine();

double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++) // заполнение массива
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.WriteLine($"Разница между max и min = {max - min}");
