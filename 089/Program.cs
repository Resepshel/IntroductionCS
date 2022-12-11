// Подсчитать сумму цифр, встречающихся в строке

int SumNum(string str) {
    int sum = 0;
    for(int i=0;i<str.Length;i++) {
        if (char.IsDigit(str[i])) {
            sum=sum+Convert.ToInt32(str[i].ToString());
        }
    }
    return sum;
}

string str = Console.ReadLine();
Console.WriteLine(SumNum(str));
