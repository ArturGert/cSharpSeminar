/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
int GetNumber (string message)
{
    int result;
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out result))
        break;
        else System.Console.WriteLine("Введено не число! Повторите ввод!");
    }
    return result;
}
double[,] InitArr (int dimension1, int dimension2)
{
    Random rnd = new Random();
    double[,] myArr = new double [dimension1, dimension2];
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
            myArr[i,j] = Math.Round(rnd.Next(-10,10) + rnd.NextDouble(), 1);
    }
    return myArr;
}
void PrintArray (double [,] myArr)
{
    for (int i = 0; i < myArr.GetLength(0); i++)
    {
        for (int j = 0; j < myArr.GetLength(1); j++)
            System.Console.Write($"{myArr[i,j]} ");
    System.Console.WriteLine();
    }
}
Console.Clear();
int m = GetNumber ("Введите значение m: ");
int n = GetNumber ("Введите значение n: ");
double[,] array = InitArr(m,n);
PrintArray(array);