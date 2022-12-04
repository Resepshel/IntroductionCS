// Написать программу копирования массива

int[] RandomIntArray(int[] array)
{
    Random random=new Random();
    for(int i=0;i < array.Length;i++)
        array[i]=random.Next(0,10);
    return array;
}

void Print(int[] new_array)
{
    for(int i=0;i<new_array.Length;i++)
        System.Console.Write($"{new_array[i],2}");
}

int[] CopyArray(int[] array) {

    int[] new_array = new int[array.Length];
    for(int i=0; i < array.Length; i++) {
        new_array[i] = array[i];
    }

    return new_array;
}

int size = 5;
int[] array = new int[size];
array = RandomIntArray(array);
Print(array);
Console.WriteLine();
int[] new_array = new int[size];
new_array = CopyArray(array);
Print(new_array);
