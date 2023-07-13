// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да





Console.Write("Введите число: ");
string number = Console.ReadLine();

void IsPolindrom(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number} - палиндром.");
  }
  else Console.WriteLine($"Число: {number} - Не палиндром.");
}

if (number!.Length == 5){
  IsPolindrom(number);
}
else Console.WriteLine($"Введи пятизначное число");