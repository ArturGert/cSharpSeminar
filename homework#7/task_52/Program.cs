/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
// Решение без проверок и методов (ДО СЕМИНАРА)
int[,] myArr = new int[,] 
{
    {10, 4, 27, 2},
    {5, 19, 21, 3},
    {18, 14, 12, 4}
};
Console.Clear();
double sum0 = Convert.ToDouble((myArr[0,0] + myArr[1,0] + myArr[2,0]));
double sum1 = Convert.ToDouble((myArr[0,1] + myArr[1,1] + myArr[2,1]));
double sum2 = Convert.ToDouble((myArr[0,2] + myArr[1,2] + myArr[2,2]));
double sum3 = Convert.ToDouble((myArr[0,3] + myArr[1,3] + myArr[2,3]));
double avg0 = Math.Round((sum0 / myArr.GetLength(0)), 2);
double avg1 = Math.Round((sum1 / myArr.GetLength(0)), 2);
double avg2 = Math.Round((sum2 / myArr.GetLength(0)), 2);
double avg3 = Math.Round((sum3 / myArr.GetLength(0)), 2);
System.Console.WriteLine($"Среднее арифмитическое соответствующего столбца: {avg0} ; {avg1} ; {avg2} ; {avg3}");

//  Модное решение с методом! (пока не додумал)
/*
int GetNumber (string message)  // Проверяет вводимое значение
{
    int result;
    while(true)
    {
        System.Console.Write(message);
        if (int.TryParse(Console.ReadLine() ?? " ", out result) && result >=0)
            break;
        else System.Console.WriteLine("Введено недопустимое значение! Введите натуральное число");
    }
    return result;
}
int [,] GetArray (int dimension1, int dimension2)
{
    Random rnd = new Random();
    int [,] myArr = new int [dimension1,dimension2];
    for (int i = 0; i < myArr.GetLength(0); i++)
        for (int j = 0; j < myArr.GetLength(1); j++)
            myArr[i,j] = rnd.Next(0,10);
    return myArr;   
}
void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i,j]} ");
    System.Console.WriteLine();    
    }
    System.Console.WriteLine(); 
}

void GetSumm (int [,] array)
{
    double sum = 0;
    double avg = 0;
    for (int i = 0; i < array.GetLength(0);)
    {
        for (int j = 0; j < array.GetLength(0);)
        {
            sum += array[i,0];
            avg = sum / array.GetLength(0)-1;
            System.Console.WriteLine($" " + avg);
            j++;
        }
      
    } 
}
Console.Clear();
int m = GetNumber ("Введите размерность строки массива: ");
int n = GetNumber ("Введите размерность столбца массива: ");
int [,] newArr = GetArray(m,n);
PrintArray(newArr);
GetSumm(newArr);*/

