// // Масимальное из 3 чисел

// int first = 8;
// int second = 10;
// int third = 8;

// if (first == second || second == third || first == third)
// {
//     Console.WriteLine("Какие-то из чисел равны");
// }
// else if (first > second && first > third)
// {
//     Console.WriteLine("Первое число самое большое");
// }
// else if (second > first && second > third)
// {
//     Console.WriteLine("Второе число самое большое");
// }
// else if (third > first && third > second)
// {
//     Console.WriteLine("Третье число самое большое");
// }


// // Условные выражения
// // && - логическое И (должны выполняться все условия)
// int x = 11;
// if (x > 5 && x < 10)
// {
//     Console.WriteLine("Победа!");
// }
// else
// {
//     Console.WriteLine("Тоже победа, но другая");
// }


// // || - логическое ИЛИ (должны выполниться хотя бы одно условие)
// int x = 11;
// if (x > 5 || x < 10)
// {
//     Console.WriteLine("Победа!");
// }
// else
// {
//     Console.WriteLine("Тоже победа, но другая");
// }


// // ! - логическое НЕ (если было true станет false и наоборот)
// int x = 3;
// if (!(x > 5))
// {
//     Console.WriteLine("Победа!");
// }
// else
// {
//     Console.WriteLine("Тоже победа, но другая");
// }


// // Случайное число
// // Диапазон указывается через запятую.
// // От первого числа включительно до второго числа НЕ включительно
// int randomNumber = new Random().Next(10, 20); // от 10 до 19 включительно
// Console.WriteLine(randomNumber);

// Операции с числами
// % - остаток от деления
// 4 % 2 == 0
// Console.WriteLine(5 / 2); // 2.5 -> 2


// // Напишите программу, которая выводит случаное число из отрезка [10, 99] 
// // и показывает наибольшую цифру числа
// // 78 -> 8
// // 12 -> 2
// // 85 -> 8

// int number = new Random().Next(10, 99);
// Console.WriteLine("Случайное число: " + number);
// int first = number / 10; // 45 / 10 == 4 (отбрасываем десятичное)
// int second = number % 10; // 45 % 10 == 5

// if (first > second)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + first);
// }
// if (second > first)
// {
//     Console.WriteLine("Наибольшая цифра числа: " + second);
// }
// if (first == second)
// {
//     Console.WriteLine("Цифры числа равны");
// }



// // Задача 1. Напишите программу, которая выводит случаное трёхзначное число 
// // и удаляет вторую цифру этого числа
// // 456 -> 46
// // 782 -> 72
// // 918 -> 98

// // Console.WriteLine("Случайное число: "); // если вводить число вручную
// // string str = Console.ReadLine();
// // int number = int.Parse(str);

// int number = new Random().Next(100, 1000);
// Console.WriteLine("Случайное число: " + number);

// int first = number / 100;
// int third = number % 10;

// Console.WriteLine("Результат:" + first + third);


// // Задача 2. Напишите программу, которая будет принимать на вход два числа и выводить,
// // является ли второе число кратным первому. Если второе число не красно первому,
// // то программа выводит остаток от деления. 
// // 34, 5 -> не кратно, остаток 4
// // 16, 4 -> кратно

// Console.WriteLine("Введите первое число: ");
// string str = Console.ReadLine();
// int first = int.Parse(str);
// Console.WriteLine("Введите второе число: ");
// string str2 = Console.ReadLine();
// int second = int.Parse(str2);

// int a = first % second;

// if (a == 0) 
// {
//     Console.WriteLine("Первое число кратно второму");
// }
// else
// {
//     Console.Write("Первое число НЕ кратно второму, ");
//     Console.WriteLine("остаток: " + a);
// }

 
// // Задача 3. Напишите программу, которая принимает на вход число и проверяет, 
// // кратно ли оно одновременно 7 и 23.
// // 14 -> нет
// // 46 -> нет
// // 161 -> да

// Console.Write("Введите число: ");
// string str = Console.ReadLine();
// int number = int.Parse(str);
// int a = 7;
// int b = 23;

// if (number % a == 0 && number % b == 0)
// {
//     Console.WriteLine("Ваше число кратно одновременно двум числам");
// }
// else
// {
//     Console.WriteLine("Попробуйте другое число");
// }