// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num / 100 % 10 == 0){
    Console.WriteLine("NO");
} else {
    Console.WriteLine(num / 100 % 10);
}
