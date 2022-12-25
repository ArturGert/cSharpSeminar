/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
// Пишем метод проверки на число
// Пишем метод инициализации массива (матрицы) (матрицы должны быть согласованы)
// Пишем метод печати массива (матрицы)
// Пишем метод умножения массивов (матриц)

//Метод проверки на число
int GetNumber(string message)
{
    int result;
    while (true)
    {
        System.Console.WriteLine(message);
        if (int.TryParse((Console.ReadLine()), out result) && result > 0)
            break;
        else System.Console.WriteLine("Введено недопустимое значение! Повторите ввод!");
    }
    return result;
}

// Метод инициализации массивов (матриц)
(int[,], int[,]) InitArrays(int rowSize1, int columnSize1, int columnSize2)
{
    int[,] matrix1 = new int[rowSize1, columnSize1];
    int[,] matrix2 = new int[columnSize1, columnSize2];
    Random rnd = new Random();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
            matrix1[i, j] = rnd.Next(0, 10);
    }
    for (int i = 0; i < matrix2.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
            matrix2[i, j] = rnd.Next(0, 10);
    return (matrix1, matrix2);
}

// Печать массива/матрицы
void PrintArray(string message, int[,] matrix)
{
    System.Console.WriteLine(message);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            System.Console.Write($"{matrix[i, j]}\t");
        System.Console.WriteLine();
    }
    Console.WriteLine();
}

// Перемножает массивы (матрицы)
int [,] GetMiltMatrix(int[,] matrix1, int[,] matrix2)
{
    int [,] matrix3 = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                
                matrix3[i,j] +=  matrix1[i,k] * matrix2[k,j];
            }
        }
    return matrix3;
}
Console.Clear();
Console.WriteLine("ВНИМАНИЕ! Для соблюдения условия согласованности матриц вводимое значение числа столбцов матрицы А соответствует числу строк матрицы В!");
int row1 = GetNumber("Введите число строк матрицы А");
int columns1 = GetNumber("Введите число столбцов матрицы А");
int columns2 = GetNumber("Введите число столбцов матрицы В");
(int[,] matrixA, int[,] matrixB) = InitArrays(row1, columns1, columns2);
int[,] matrixC = GetMiltMatrix(matrixA, matrixB);
PrintArray($"Матрица А: \n", matrixA);
PrintArray($"Матрица B: \n", matrixB);
PrintArray($"Матрица C = А * B: \n", matrixC);