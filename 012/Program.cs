// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

Console.Write("Введите число из диапозона (10-99): ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num % 10;
int num2 = num / 10;

if (num1 > num2) {
    Console.WriteLine($"Наибольшая цифра числа: {num1}");
} else {
    Console.WriteLine($"Наибольшая цифра числа: {num2}");
}
