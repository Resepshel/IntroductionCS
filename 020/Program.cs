// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите координату x: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y: ");
int y=Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) {
    Console.WriteLine("Первая четверть");
} else if (y > 0 && x < 0) {
    Console.WriteLine("Вторая четверть");
} else if (y < 0 && x < 0) {
    Console.WriteLine("Третья четверть");
} else if (y < 0 && x > 0) {
    Console.WriteLine("Четвертая четверть");
}
