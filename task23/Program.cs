// Задача 39 : Напишите программу, которая перевернет одномерный массив.
// Последний элемент будет на первом месте, а первый на последнем
// [1,2,3,4,5] -> [5,4,3,2,1]


int[] FillArrayWithRandomNumber(int size)
{
int[] arr = new int[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.Next(0, 10);
}
return arr;
}
void ReverceArray (int[] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.Length / 2; i ++)
    {
        temp = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = temp;
    }


}
// int ReverceArray (int[] arr)
// {
//     int temp = 0;
//     for (int i = 0; i < arr.Length / 2; i ++)
//     {
//         temp = arr[i];
//         arr[i] = arr[arr.Length - 1 - i];
//         arr[arr.Length - 1 - i] = temp;
//     }

//     return arr;       Не работате из-за ретурна !
// }
System.Console.Write("Введите кол-во элементов массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumber(length);
System.Console.WriteLine(string.Join("; ", array));
ReverceArray(array);
System.Console.WriteLine(string.Join("; ", array));
