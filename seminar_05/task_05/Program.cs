// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// string str = Console.ReadLine();
// int sum = 0;

// // for (int i = 0; i < str.Length; i++)
// // {
// //     char currentChar = str[i];
// //     int positionOfChar = Convert.ToInt32(currentChar);
// //     int numberFromChar = int.Parse(currentChar.ToString());
// //     Console.Write($"Сивол: {currentChar}, позиция: {positionOfChar}, число: {numberFromChar} \n");
// // }

// for (int i = 0; i < str.Length; i++)
// {
//     int currentNumber = int.Parse(str[i].ToString());
//     sum += currentNumber; // sum = sum + currentNumber
// }
// Console.WriteLine(sum);



// // Правила по стилю написания кода (code style)
// // Все названия любых структур языка должны описывать то, что они делают или хранят
// // Переменные: первое слово пишется с маленькой буквы, следующие слова с большой
// string textFromConsole; // Текст из консоли
// string text; // вот так не надо, это не информативно

// // Функции (Класс, интерфейсы, структуры, перечисления): Все слова с первого пишутся с большой буквы
// int GetRandomNumber(int from, int to) // Получение случайного числа
// {
//     return 0; // заглушка
// }

// // // Заполение массива:
// // int[] array = {new Random().Next(0, 10)}; // так не сработает, будет только одно число
// int[] array = new int[4]; // 4 - размер (количество)

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(0, 10); // генерируем случайное число
//     array[i] = randomNumber; // кладём в массив на место с индексом i
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++) // изменение массива уже после заполнения
// {
//     array[i] = array[i] + 5;
// }

// for (int i = 0; i < array.Length; i++)
// {
//     Console.Write(array[i] + " ");
// }



// // Задача 1. Задайте массив из 10 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите суммы отрицательных и положительных элементов массива.
// // Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int sumPosNum = 0;
// int sumNegNum = 0;
// int[] array = new int[10]; // размер массива

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;
//     Console.Write(array[i] + " " );
// }

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] < 0)
//     {
//         sumPosNum = sumPosNum + array[i];  
//     }
//     if (array[i] > 0)
//     {
//         sumNegNum = sumNegNum + array[i];
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел = {sumPosNum}");
// Console.WriteLine($"Сумма отрицательных чисел = {sumNegNum}");


// // // Задача 2. Задайте массив из 10 элементов и положительные элементы замените на соответствующие отрицательные, и наоборот.
// // // [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[10]; // размер массива

// for (int i = 0; i < array.Length; i++) // заполнение массива
// {
//     int randomNumber = new Random().Next(-9, 10);
//     array[i] = randomNumber;
//     Console.Write(array[i] + " " );
// }
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;   
//     Console.Write(array[i] + " ");
// }