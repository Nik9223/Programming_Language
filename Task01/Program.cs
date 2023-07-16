// 1. Напишите программу, которая на вход принимает два числа
// и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3, b = 9 -> нет

Console.WriteLine("Введите два числа и мы узнаем является ли первое число квадратом второго");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int scr = number2 * number2;

if(scr == number1)
{
    Console.WriteLine($"Да, первое число {number1} - это квадрат числа {number2}.");
}
else
{
    Console.WriteLine($"Нет, первое число {number1} - это не квадрат числа {number2}.");
}