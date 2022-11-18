// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}

Console.WriteLine($"Максимальное число = {max}");