// Показать натуральные числа от M до N, N и M заданы

void NaturalNum(int m, int n) {

    if (m<n) {
        Console.WriteLine(m);
        NaturalNum(m+1, n);
    } else if (m>n) {
        Console.WriteLine(m);
        NaturalNum(m-1, n);
    } else if (m==n) {
        Console.WriteLine(m);
    }
}

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
NaturalNum(m, n);