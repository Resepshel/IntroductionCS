// Дано число больше 9. Вывести на экран вторую цифру числа с конца

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(a/10%10);