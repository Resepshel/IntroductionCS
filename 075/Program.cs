// Написать программу вычисления функции Аккермана

int Ack(int n, int m) {
    if (n==0) {
        return m+1;
    } else if (m==0) {
        return Ack(n-1,1);
    } else {
        return Ack(n-1, Ack(n,m-1));
    }
}

Console.WriteLine(Ack(3, 6));
