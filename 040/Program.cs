// Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int[] ArrayRandom(int size) {

    int[] array = new int[size];
    for(int i=0;i<array.Length;i++) {
        array[i] = new Random().Next(1, 11);
    }
    return array;
}

void PrintArray(int [] res) {
    for(int i=0; i<res.Length; i++)
        Console.Write($"{res[i]} ");
}

int[] NewMass(int[] array) {

    int[] newArray = new int[array.Length/2];
    int end = array.Length-1;
    for(int begin=0; begin < newArray.Length; begin++) {
        newArray[begin] = array[begin] * array[end];
        end--;
    }
    return newArray;
}

Console.Write("Введите кол-во элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = ArrayRandom(size);
Console.WriteLine("Исходный массив: ");
PrintArray(arr);
Console.WriteLine("\n");
int[] res = NewMass(arr);
PrintArray(res);
