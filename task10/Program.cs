// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

void PrintQuater(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("Точка в 1-й четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Точка во 2-й четверти");
    }
    else if(x < 0 && y > 0)
    {
        Console.WriteLine("точка в 3-й четверти");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("Точка в 4-й четверти");
    }
    else
    {
        Console.WriteLine("Точка на оси координат");
    }
}




Console.WriteLine("Введите координату X :");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = Convert.ToInt32(Console.ReadLine());

PrintQuater(x, y);