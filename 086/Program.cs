// Подсчитать сколько раз определенный символ (например 'a') встречается в строке

int CountFind(string str, char find) {
    int count = 0;
    foreach(char c in str) {
        if (c == find) {
            count++;
        }
    }
    return count;
}

string str = Console.ReadLine();
char find = 'a';
Console.WriteLine(CountFind(str, find));
