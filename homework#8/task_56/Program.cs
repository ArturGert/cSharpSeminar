/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
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
            newArray[i, j] = rnd.Next(0, 10);
    return newArray;
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

void GetSumm(int[,] newArray)
{
    int[] sum = new int[newArray.GetLength(0)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            sum[i] += newArray[i, j];
        }
    }
    int minNumber = sum[0];
    int index = 0;
    for (int i = 0; i < sum.Length; i++)
    {
        if (sum[i] < minNumber)
        {
            minNumber = sum[i];
            index = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов - {index}, сумма которых равна {minNumber}");
}
Console.Clear();
int rowSize = GetNumber("Введите размерность строк: ");
int columnSize = GetNumber("Введите размерность столбцов ");
int[,] numArray = InitArray(rowSize, columnSize);
PrintArray(numArray);
GetSumm(numArray);
