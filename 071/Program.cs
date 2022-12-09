// Показать натуральные числа от N до 1, N задано

void NaturalNum(int n) {

    int count=n;
    if (count>0) {
        Console.WriteLine(count);
        NaturalNum(count-1);
    }
}

int n = Convert.ToInt32(Console.ReadLine());
NaturalNum(n);