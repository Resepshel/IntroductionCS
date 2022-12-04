// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void FindDot(out double x, out double y, int k1, int b1, int k2, int b2) {
    double one = k1 - k2;
    double two = b1 - b2;

    x = (-two) / one;
    y = k1*x + b1;
}

int k1 = 2;
int b1 = -1;
int k2 = -3;
int b2 = 1;
double x;
double y;

FindDot(out x, out y, k1, b1, k2, b2);
Console.WriteLine($"{x}\n{y}");