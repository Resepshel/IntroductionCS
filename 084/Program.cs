// Определить являются ли введенные с клавиатуры символы правильно записью целого числа. Вычислить сумму цифр введенного числа

string SumNum(string s) {
    int sum = 0;
    if (IsDigital(s)) {
        int n = Int32.Parse(s);
        while(n!=0)
        {
            sum=sum+n%10;
            n=n/10;
        }
        return $"{sum}";
    } else {
        return "Это не целое число";
    }
}

bool IsDigital(string s) {
    foreach(char c in s) {
        if (!char.IsDigit(c)){
            return false;
        }
    }
    return true;
}


string s=Console.ReadLine();
Console.WriteLine(SumNum(s));

