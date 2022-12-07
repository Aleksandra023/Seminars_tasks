// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int sum = 0;
int[] array = new int[10];

for (int i = 0; i < array.Length; i++) // заполнение массива
{
    int randomNumber = new Random().Next(0, 11);
    array[i] = randomNumber;
    Console.Write(array[i] + " " );

    if (i % 2 == 1)
    {
        sum = sum + array[i];
    }
}

Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетной позиции = {sum}");