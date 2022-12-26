/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

// Создаем массив 4 х 4
int[,] array = new int[4, 4];

// Метод, заполняющий заданный массив по спирали (работает только с квадратными массивами)
int[,] SortArray(int[,] array)
{
    int[,] sortArr = array;
    int value = 1;
    for (int i = 0; i <= array.GetLength(0) / 2; i++)
    {
        for (int j = i; j < array.GetLength(0) - i; j++)
        {
            sortArr[i, j] = value;
            value++;
        }
        for (int j = i + 1; j < array.GetLength(0) - i; j++)
        {
            sortArr[j, array.GetLength(0) - 1 - i] = value;
            value++;
        }
        for (int j = array.GetLength(0) - 2 - i; j >= i; j--)
        {
            sortArr[array.GetLength(0) - 1 - i, j] = value;
            value++;
        }
        for (int j = array.GetLength(0) - 2 - i; j > i; j--)
        {
            sortArr[j, i] = value;
            value++;
        }
    }
    return sortArr;
}
void PrintArray(int[,] newArray)
{
    System.Console.WriteLine();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            System.Console.Write($"{newArray[i, j]}\t");
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] Array = SortArray(array);
PrintArray(Array);
