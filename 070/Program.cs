// Показать натуральные числа от 1 до N, N задано

void NaturalNum(int count, int n) {

    if (count<=n) {
        Console.WriteLine(count);
        NaturalNum(count+1,n);
    }
}

int n = Convert.ToInt32(Console.ReadLine());
NaturalNum(1, n);
