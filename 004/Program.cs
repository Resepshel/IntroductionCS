﻿// По заданному с клавиатуры номеру дня недели вывести его название

Console.Write("Введите день недели в виде числа: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) {
    Console.WriteLine("Понедельник");
} else if (day == 2) {
    Console.WriteLine("Вторник");
} else if (day == 3) {
    Console.WriteLine("Среда");
} else if (day == 4) {
    Console.WriteLine("Четверг");
} else if (day == 5) {
    Console.WriteLine("Пятница");
} else if (day == 6) {
    Console.WriteLine("Суббота");
} else if (day == 7) {
    Console.WriteLine("Воскресенье");
} else {
    Console.WriteLine("Такого дня недели не существует");
}