// Удалить вторую цифру целого числа введенного с клавиатуры.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = num / 100 * 10 + num % 10;
System.Console.WriteLine(res);