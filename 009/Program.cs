// Вывести на экран четные числа от 1 до N

int N=Convert.ToInt32(Console.ReadLine());

for(int j=1;j<=N;j=j+1)
{
    if (j%2==0)
    {
        System.Console.Write($"{j} ");
    }
}
