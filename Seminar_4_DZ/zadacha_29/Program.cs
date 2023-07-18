// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.Write("Введите количество элементов массива, не более 8 : ");
int element = Math.Abs(Convert.ToInt32(Console.ReadLine()));                                     //int.Parse(Console.ReadLine());


int[] array = new int[element];

if ( element > 1 || element <= 8)
{
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент под индексом {i}:\t");
    array[i] = int.Parse(Console.ReadLine());
}
    Console.Write("Вывод массива:");



    Console.WriteLine($"[{string.Join(", ", array)}]");


}
else 
{
    Console.WriteLine("Введите число от 1 до 8");
    
}




// Не осилил запрет ввода в консоли всех знаков , кроме положительних чисел...



