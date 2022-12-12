/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
void GetArr(int[] array) //Заполняет массив случайными трехзначными числами
{
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100,1000); // от 100 до 999
}
void PrintArr(int[] array) //Выводит полученный массив на консоль 
{
for (int i = 0; i < array.Length; i++)
    System.Console.Write(array[i] + (i < array.Length -1 ? "," : ""));
}
void GetCount (int[] myArr) // Определяет количество четных чисел в массиве
{
int count = 0;
for (int i = 0; i < myArr.Length; i++)
{
    if (myArr[i] % 2 == 0)
        count ++;
}
System.Console.WriteLine();
System.Console.WriteLine($"Количество четных чисел в заданном массиве составляет {count}"); 
}
Console.Clear();
int[] myArr = new int[10];
GetArr(myArr);
PrintArr(myArr);
GetCount(myArr);