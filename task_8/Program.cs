﻿// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно
// 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да


void PrintMultipy (int num)
{
if (num % 7 == 0 && num % 23 == 0)
{
System.Console.WriteLine ("Да");

}
else
{
    System.Console.WriteLine ("Нет");
}

}
System.Console.Write("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintMultipy (number);