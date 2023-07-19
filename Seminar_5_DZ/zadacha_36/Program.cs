﻿// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



int[] MyArray(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(1, 10);
}
return arr;
}


System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = MyArray(length);
System.Console.Write($"[{string.Join("; ", array)}] -> ");


int sum = 0;
for (int i = 0; i< array.Length; i ++)    
{

    if (i % 2 != 0)
    {
        sum = sum + array[i];
    }
    
}
Console.Write(sum);
