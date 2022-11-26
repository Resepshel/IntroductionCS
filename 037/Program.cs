// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] ArrayRandom(int size) {

    int[] array = new int[size];
    for(int i=0;i<array.Length;i++) {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void EvenAndOddNumbers(int[] array, out int oddNum, out int evenNum) {

    oddNum = 0;
    evenNum = 0;
    foreach (int el in array) {
        if (el % 2 == 1) {
            oddNum++;
        } else {
            evenNum++;
        }
    }
}

void PrintArray(int [] res) {
    for(int i=0; i<res.Length; i++)
        Console.Write($"{res[i]} ");
}

int size = 10;
int evenNum;
int oddNum;
int[] arr = ArrayRandom(size);
Console.Write($"Массив чисел: ");
PrintArray(arr);
Console.WriteLine("\n");
EvenAndOddNumbers(arr, out evenNum, out oddNum);
Console.WriteLine($"Кол-во чётных чисел: {evenNum}\nКол-во нечётных чисел: {oddNum}");
