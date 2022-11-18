// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a%10);