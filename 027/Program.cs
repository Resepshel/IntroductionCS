// Возведите число А в натуральную степень B используя цикл

void PowerB(int a, int b) {
    int res = 1;
    for (int i=1; i <= b; i++) {
        res *= a;
    }
    Console.WriteLine(res);
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
PowerB(a, b);