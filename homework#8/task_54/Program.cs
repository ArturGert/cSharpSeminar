/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int GetNumber(string message)
{
    int result;
    while (true)
    {
        System.Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else System.Console.WriteLine("Введено не число! Повторите ввод!");
    }
    return result;
}

int[,] InitArray(int rowSize, int columnSize)
{
    int[,] newArray = new int[rowSize, columnSize];
    Random rnd = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i, j] = rnd.Next(1, 10);
    return newArray;
}

void PrintArray(int[,] newArray)
{
    System.Console.WriteLine();
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            System.Console.Write($"{newArray[i, j]}\t");
        System.Console.WriteLine($"\n");
    }
    System.Console.WriteLine();
}

int[,] GetStreamlineArray(int[,] array)
{
    int[,] streamArr = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int l = 0; l < array.GetLength(1); l++)
            {
                for (int j = 0; j < array.GetLength(1) - l - 1; j++)
                {

                    if (array[i, j] < array[i, j + 1])
                    {
                        int temp = array[i, j];
                        array[i, j] = array[i, j + 1];
                        array[i, j + 1] = temp;
                    }
                }
            }
            streamArr[i, k] = array[i, k];
        }
    }
    return streamArr;
}
int rowSize = GetNumber("Введите размерность строк: ");
int columnSize = GetNumber("Введите размерность столбцов ");
int[,] numArray = InitArray(rowSize, columnSize);
PrintArray(numArray);
int[,] streamArr = GetStreamlineArray(numArray);
PrintArray(streamArr);