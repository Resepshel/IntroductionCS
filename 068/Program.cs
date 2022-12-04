// Написать программу, которая обменивает элементы первой строки и последней строки

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
        System.Console.Write($"{a[i,j],4}");
           System.Console.WriteLine();
        }
}

int[,] ChangeArray(int[,] array) {

    for(int j=0;j<array.GetLength(1);j++) {
        int t = array[0,j];
        array[0,j] = array[array.GetLength(0)-1,j];
        array[array.GetLength(0)-1,j] = t;
    }
    return array;
}

int m = 5;
int n = 5;
int[,] a=Random2DArray(m,n);
Print2DArray(a);
Console.WriteLine();
a = ChangeArray(a);
Print2DArray(a);
