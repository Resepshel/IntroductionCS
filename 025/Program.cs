// Вывести на экран кубы чисел от 1 до N

void PowerThree(int n) {
    for (int i=1; i <= n; i++) {
    Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");
    }
}

int n = Convert.ToInt32(Console.ReadLine());
PowerThree(n);
