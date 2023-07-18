﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] myArray(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(100, 1000);
}
return arr;
}

System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = myArray(length);
System.Console.Write($"[{string.Join("; ", array)}] -> ");

int count = 0;
for (int i = 0; i < array.Length; i ++)
{
    if (array[i] % 2 == 0)
    {
     count ++;
     
    }
    
}
Console.Write(count);


