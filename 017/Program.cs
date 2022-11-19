// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());


if (day == 6 || day == 7) {
    Console.WriteLine("Это выходной день");
} else if (0 < day && day < 6) {
    Console.WriteLine("Это будний день");
} else {
    Console.WriteLine("Такого дня недели не существует");
}
