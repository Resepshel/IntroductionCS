// Показать двумерный массив размером m×n заполненный вещественными случайными числами

double[,] Random2DArray(int n,int m,double min=0,double max=10)
{
    double[,] a=new double[n,m];
    Random random=new Random();
    for(int i=0;i<n;i++)
         for(int j=0;j<m;j++)
                a[i,j]=Math.Round(random.NextDouble() * 10, 1);
    return a;
}

void Print2DArray(double[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],7}");
           System.Console.WriteLine();
        }
}

int m = 5;
int n = 5;
double[,] a=Random2DArray(m,n);
Print2DArray(a);

