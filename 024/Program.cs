// Вывести на экран таблицу квадратов чисел от 1 до N

void PowerTwo(int n) {
    for (int i=1; i <= n; i++) {
    Console.WriteLine($"{i}^2 = {i*i}");
    }
}

int n = Convert.ToInt32(Console.ReadLine());
PowerTwo(n);
