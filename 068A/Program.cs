// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] Random2DArray(int n,int m,int min=0,int max=10)
{
    int[,] a=new int[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=random.Next(min,max+1);
    return a;
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],5}");
           System.Console.WriteLine();
        }
}

int SumMin(int[,] array) {
    int sum = 0;
    for(int j=0;j<array.GetLength(1);j++) {
        sum += array[0,j];
    }
    int min = sum;
    int res = 1;
    for(int i=1;i<array.GetLength(0);i++) {
        sum = 0;
        for(int j=0;j<array.GetLength(1);j++) {
            sum += array[i,j];
        }
        if(sum < min) {
            min = sum;
            res = i+1;
        }
    }
    return res;
}

int m = 5;
int n = 4;
int[,] a=Random2DArray(m,n);
Print2DArray(a);
Console.WriteLine();
int res = SumMin(a);
Console.WriteLine(res);