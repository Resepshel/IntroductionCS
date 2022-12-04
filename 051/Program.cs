// С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

int NumAboveZero(int n, int res) {
    int count = 1;
    while (count <= n) {
        Console.Write($"Введите {count} число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0) {
            res ++;
        }
        count ++;
    }
    return res;
}

Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
res = NumAboveZero(n, res);
Console.WriteLine($"Кол-во чисел >0: {res}");