// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

// Console.Write("Введите номер дня недели:  ");
// int dey = Convert.ToInt32(Console.ReadLine());  


// if (dey > 7 || dey <1)
// {
//     Console.Write("Такого дня недели не существует");
//     return;
// }
//if(dey == 1) Console.Write("Понедельник");

Console.Write("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

switch (day)
{
case 1:
Console.WriteLine("Понедельник");
break;
case 2:
Console.WriteLine("Вторник");
break;
case 3:
Console.WriteLine("Среда");
break;
case 4:
Console.WriteLine("Четверг");
break;
case 5:
Console.WriteLine("Пятница");
break;
case 6:
Console.WriteLine("Суббота");
break;
case 7:
Console.WriteLine("Воскресенье");
break;
default:
Console.WriteLine("Дня недели с таким номером не существует");
break;
}