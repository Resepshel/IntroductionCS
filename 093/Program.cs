// See https://aka.ms/new-console-template for more information

int mult = 0;
int sum = 0;

int[,] firstMatrix = {{1,4,7,2},
                      {5,9,2,3},
                      {8,4,2,4},
                      {5,2,6,7}};

int[,] secondMatrix = {{1,5,8,5},
                       {4,9,4,2},
                       {7,2,2,6},
                       {2,3,4,7}};

int[,] resultMatrix = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];

if(firstMatrix.GetLength(1) == secondMatrix.GetLength(0)) {
    for(int i=0;i<firstMatrix.GetLength(0);i++) {
        for(int j=0;j<secondMatrix.GetLength(1);j++) {
            sum = 0;
            for(int k=0;k<firstMatrix.GetLength(1);k++) {
                mult = firstMatrix[i,k] * secondMatrix[k,j];
                sum += mult;
            }
            resultMatrix[i,j] = sum;
        }
    }
} else {
    Console.WriteLine("Данные матрицы нельзя перемножать");
}

void Print2DArray(int[,] a)
{
    for(int i=0;i<a.GetLength(0);i++)
        {
     for(int j=0;j<a.GetLength(1);j++)
        System.Console.Write($"{a[i,j],7}");
           System.Console.WriteLine();
        }
}

Print2DArray(resultMatrix);