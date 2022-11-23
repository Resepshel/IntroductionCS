// Найти сумму чисел от 1 до А

int SumNum(int a) {
    int res = 0;
    for (int i = 1; i <= a; i++){
        res += i;
    }
    return res;
}

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNum(a));

