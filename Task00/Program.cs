using System;
// 0. Демонстрация решения.
// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдает его квадрат(число 
// умноженое на само себя)
// 3. Вывод результата

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int square = number * number;
// Console.WriteLine("Квадрат числа: " + square);

Console.WriteLine($"Квадрат числа: {number} = {square}");

// Match.Pow(number, 2);
// int number = Convert.ToInt32(Console.ReadLine()); числа
// double number1 = Convert.ToDouble(Console.ReadLine());
// string str1 = Console.ReadLine(); строки
// string str = "";
// double d = 4.545;
// -2 147 483 648 до 2 147 483 647

// 7. Напишите программу, которая принимает на вход трехзначное число и
// на выходе показывает последнюю цифру этого числа.

// int num1 = 456; // 450
// int res1 = num1 % 10;