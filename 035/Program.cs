// Написать программу замены элементов массива на противоположные

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

int[] ReversArray(int[] array) {

    int middle;
    int end=array.Length-1;
    for(int begin=0; begin < array.Length; begin++){

        if (begin < end) {
            middle = array[begin];
            array[begin] = array[end];
            array[end] = middle;
        } else if (begin == end || begin > end) {
            break;
        }
        end--;
    }
    return array;
}

int size = 8;
int[] res = ArrayRandom(size);
Console.Write("Начальный массив: ");
PrintArray(res);
Console.Write("\n");
int[] newArray = ReversArray(res);
Console.Write("Перевернутый массив: ");
PrintArray(newArray);