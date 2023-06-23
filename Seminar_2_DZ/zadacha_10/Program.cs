// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1



Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;

if (length == 3)
{
int result = (number / 10) % 10;
Console.WriteLine($"Вторая цифра -> {result}");

}
else
{
    Console.Write(" Это не трёхзначное число :( ");
}
