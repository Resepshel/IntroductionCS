// Задать массив из 8 целых элементов и вывести их на экран

int[] ArrayRandom(int size) {

    int[] array = new int[size];
    for(int i=0;i<array.Length;i++) {
        array[i] = new Random().Next(0, 101);
    }
    return array;
}

void PrintArray(int [] res) {
    for(int i=0; i<res.Length; i++)
        Console.Write($"{res[i]} ");
}

int size = 8;
int[] res = ArrayRandom(size);
PrintArray(res);
