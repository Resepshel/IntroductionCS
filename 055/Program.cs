/* Написать программу масштабирования фигуры
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
например: "(0,0) (2,0) (2,2) (0,2)"
коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
В результате показать координаты, которые получатся.
при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

string CalcScal(string str, double k) {
    string res = "";
    double mul = 0;
    str = str.Replace(',', ' ');
    string[] array = str.Split(' ');
    for(int i=0;i < array.Length;i++) {
        if (array[i].Contains('(')) {
            array[i] = array[i].Replace("(", string.Empty);
            int a = Convert.ToInt32(array[i]);
            mul = a * k;
            res += $"({mul},";
        } else {
            array[i] = array[i].Replace(")", string.Empty);
            int a = Convert.ToInt32(array[i]);
            mul = a * k;
            res += $"{mul}) ";
        }

    }
    return res;
}


string str = "(0,0) (2,0) (2,2) (0,2)";
double k = 2;
string res = CalcScal(str, k);

Console.WriteLine(res);