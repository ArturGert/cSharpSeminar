/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
Console.Clear();
int[] newArr = new int [8];
Random nums = new Random();
for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = nums.Next(0, 99);
}
for (int i = 0; i < newArr.Length; i++)
{
    System.Console.Write(newArr[i] + " ");
}