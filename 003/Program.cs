﻿// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

Console.Write("Введите число a: ");
double a=Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b: ");
double b=Convert.ToDouble(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"{a} > {b}");    
}
else
{
    Console.WriteLine($"{b} > {a}");
}