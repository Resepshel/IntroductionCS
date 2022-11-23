// Подсчитать сумму цифр в числе. Сделать подпрограмму.

int SumNum(string n) {
    int mod = 0;
    int res = 0;
    int count = n.Length;
    int num = Convert.ToInt32(n);
    for (int i=1; i <= count; i++) {
        mod = num % 10;
        num /= 10;
        res += mod;
    }
    return res;
}

string? n = Console.ReadLine();
Console.WriteLine(SumNum(n));


