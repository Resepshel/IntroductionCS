// Написать подпрограмму, поиска элемента в двумерном массиве, подпрограмма возвращает позицию числа.
// Если элемент отсутствует, подпрограмма возвращает -1.

int[,] Random2DArray(int n,int m,int min=0,int max=50)
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

string LinearSearch2DArray(int[,] a,int find)
{
    for(int i=0;i<a.GetLength(0);i++) {
            
        for(int j=0;j<a.GetLength(1);j++) {
            if (a[i,j]==find) {
                return $"Строка: {i+1}\nСтолбец: {j+1}";
            }
        }
    }
    return "-1";   

}

int m = 5;
int n = 5;
int[,] a=Random2DArray(m,n);
Print2DArray(a);
Console.WriteLine();
Console.WriteLine(LinearSearch2DArray(a, 5));