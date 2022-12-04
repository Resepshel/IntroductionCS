// В двумерном массиве n×k заменить четные элементы на противоположные по значению (a[i,j]=-a[i,j]).
// Написать отдельную подпрограмму на вход которой подается массив, а на выходе измененный массив.

int[,] Random2DArray(int n,int m,int min=-10,int max=10)
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

int[,] ChangeSign(int[,] array) {
    for(int i=0;i<array.GetLength(0);i++) {
        for(int j=0;j<array.GetLength(1);j++) {
            array[i,j] = -array[i,j];
        }
    }
    return array;
}

int m = 5;
int n = 5;
int[,] a=Random2DArray(m,n);
Print2DArray(a);
Console.WriteLine();
a = ChangeSign(a);
Print2DArray(a);