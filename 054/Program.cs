// С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

void PrintFib(int n, int start, int second, int count) {
    while (count < n) {
        int next = start + second;
        if (start == 0)
            Console.WriteLine($"{start}\n{second}\n{next}");
        else {
            Console.WriteLine(next);
        }
        start = second;
        second = next;
        count ++;

    } 
}

int n = Convert.ToInt32(Console.ReadLine());
int start = 0;
int second = 1;
int count = 2;
PrintFib(n, start, second, count);
