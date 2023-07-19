// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
//  может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


bool ChekLength (int a, int b, int c)
{
    if (a < b+c && b < a+c && c < a + b  )
    {
        return true;
    }
    else return false;
}

Console.Write("Введите число 1 : ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 : ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3 : ");
int c = Convert.ToInt32(Console.ReadLine());

ChekLength(a, b, c);
Console.Write(ChekLength(a, b, c));

