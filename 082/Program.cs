// C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

int count = 0;
string str = Console.ReadLine();

foreach(char el in str){
    if (el != '.') {
        count++;
    } else {
        break;
    }
}

Console.WriteLine(count);