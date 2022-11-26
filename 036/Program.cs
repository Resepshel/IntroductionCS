// Определить, присутствует ли в заданном массиве, некоторое число

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

int LinearSearch(int[] m,int find,int startIndex=0)
{
    int i=startIndex;
    while(i<m.Length && m[i]!=find) i++;
    if (i==m.Length)
        return -1;
    else
        return i;
}

int find = 25;
int size = 20;
int[] res = ArrayRandom(size);
PrintArray(res);
int res_num = LinearSearch(res, find);
if (res_num == -1) {
    Console.WriteLine("\nТакого числа нет в массиве");
} else {
    Console.WriteLine($"\nИндекс искомого числа = {res_num}");
}
