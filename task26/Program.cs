// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void PrintFib(int n)
{
    Console.WriteLine("0 1");
    int sosed1 = 0;
    int sosed2 = 1;
    int res = 0;

    for (int i = 0; i < n - 2; i++)
    {
        res = sosed1 + sosed2;
        System.Console.Write($" {res} ");
        sosed1 = sosed2;
        sosed2 = res;
    }
}

System.Console.Write("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());
PrintFib(number);

// выровнять результат