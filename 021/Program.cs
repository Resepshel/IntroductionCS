// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите четверть: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if (quarter == 1) {
    Console.WriteLine("x(0, inf); y(0, inf)");
} else if (quarter == 2) {
    Console.WriteLine("x(0, -inf); y(0, inf)");
} else if (quarter == 3) {
    Console.WriteLine("x(0, -inf); y(0, -inf)");
} else if (quarter == 4) {
    Console.WriteLine("x(0, inf); y(0, -inf)");
} else {
    Console.WriteLine("Существует всего 4 четверти");
}
