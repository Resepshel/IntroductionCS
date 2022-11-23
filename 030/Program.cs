// Написать программу вычисления произведения чисел от 1 до N

int MultNum(int n) {
    int res = 1;
    for (int i=1; i <= n; i++) {
        res *= i;
    }
    return res;
}

int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MultNum(n));
