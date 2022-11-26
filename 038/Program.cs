// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] ArrayRandom(int size) {

    int[] array = new int[size];
    for(int i=0;i<array.Length;i++) {
        array[i] = new Random().Next(0, 201);
    }
    return array;
}

void CountNumbers(out int countNum, int[] array) {

    countNum = 0;
    foreach(int el in array) {
        if (el >= 10 && el <= 99) {
            countNum++;
        }
    }    
}

void PrintArray(int [] res) {
    for(int i=0; i<res.Length; i++)
        Console.Write($"{res[i]} ");
}

int size = 123;
int countNum;
int[] arr = ArrayRandom(size);
Console.Write($"Массив чисел:\n");
PrintArray(arr);
Console.WriteLine("\n");
CountNumbers(out countNum, arr);
Console.WriteLine($"Кол-во элементов из отрезка [10, 99]: {countNum}");
