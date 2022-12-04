// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов

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

double[] Average(int[,] array) {
    double[] array_aver = new double[array.GetLength(1)];
    for(int j=0;j<array.GetLength(1);j++) {
        double aver = 0;
        for(int i=0;i<array.GetLength(0);i++) {
            aver += array[i,j];
        }
        array_aver[j] = aver/array.GetLength(0);
    }
    return array_aver;
}

int m = 5;
int n = 5;
int[,] a=Random2DArray(m,n);
Print2DArray(a);
Console.WriteLine();
double[] res = Average(a);
for(int i=0; i<res.Length; i++)
    Console.Write($"{res[i], 5}");
