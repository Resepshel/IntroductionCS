// Вывести на экран числа от -N до N

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int i=-n; i <= n; i++) {
    Console.Write($"{i} ");
}
