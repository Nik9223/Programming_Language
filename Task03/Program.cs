﻿// 3. Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.
//  3 -> Среда
//  5 -> Пятница

Console.Write("Введите номер дня недели: ");
string numDay = Console.ReadLine();

if (numDay == "1"){
    Console.WriteLine("Понедельник :/");
}
else if (numDay == "2"){
    Console.WriteLine("Вторник");
}
else if (numDay == "3"){
    Console.WriteLine("Среда");
}
else if (numDay == "4") {
    Console.WriteLine("Четверг");
}
else if (numDay == "5"){
    Console.WriteLine("Пятница");
}
else if (numDay == "6") {
    Console.WriteLine("Суббота");
}
else if (numDay == "7") {
    Console.WriteLine("Воскресенье");
}
else {
    Console.WriteLine("Вы ввели не верное значение.");
}


// Console.WriteLine("Введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());

/*if(num > 7 || num < 1)
{
    Console.WriteLine("Вы ввели не корректное значение :(");
}
if(num == 1)
{
    Console.WriteLine("Понедельник :/");
}
if(num == 2)
{
    Console.WriteLine("Вторник");
}
if(num == 3)
{
    Console.WriteLine("Среда");
}
if(num == 4)
{
    Console.WriteLine("Четверг");
}
if(num == 5)
{
    Console.WriteLine("Пятница");
}
if(num == 6)
{
    Console.WriteLine("Суббота");
}
if(num == 7)
{
    Console.WriteLine("Воскресенье");
}*/

/*switch (num)
{
    case 1:
    Console.WriteLine("Понедельник");
    break;
    case 2:
    Console.WriteLine("Вторник");
    break;
    case 3:
    Console.WriteLine("Среда");
    break;
    case 4:
    Console.WriteLine("Четверг");
    break;
    case 5:
    Console.WriteLine("Пятница");
    break;
    case 6:
    Console.WriteLine("Суббота");
    break;
    case 7:
    Console.WriteLine("Воскресенье");
    break;
    default:
    Console.WriteLine("Введенно не корректное значение.");
    break;
}*/