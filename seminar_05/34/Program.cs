// Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int count = 0;
int[] array = new int[10];

for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(100, 1000);
    array[i] = randomNumber;
    Console.Write(array[i] + " " );

    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"В массиве {count} четных чисел");