// С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a % b == 0){
    Console.WriteLine($"Число {a} кратно числу {b}");
} else {
    Console.WriteLine($"Остаток от деления {a} на {b} = {a % b}");
}
