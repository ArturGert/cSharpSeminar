/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
// Решение без проверок и методов
int[,] myArr = new int[,] 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
Console.Clear();
Console.Write("Введите индекс строки: ");
string num0 = Console.ReadLine() ?? "";
int dimension1 = Convert.ToInt32((num0));
Console.Write("Введите индекс столбца: ");
string num1 = Console.ReadLine() ?? "";
int dimension2 = Convert.ToInt32((num1));
if(dimension1 < myArr.GetLength(0) && dimension2 < myArr.GetLength(1))
    {
       System.Console.WriteLine($"Элемент с индексом {dimension1} и {dimension2} : " + myArr[dimension1,dimension2]); 
    }  
else System.Console.WriteLine($"Данный элемент в массиве отсутствует");

// Решение с применением методов и проверками на число
/*int GetNumber (string message)  // Проверяет вводимое значение
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
            myArr[i,j] = rnd.Next(10,100);
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
void GetValue (int [,] myArr, int dim1, int dim2)
{

    if(dim1 < myArr.GetLength(0) && dim2 < myArr.GetLength(1))
        System.Console.WriteLine($"Элемент с индексом {dim1} и {dim2} : " + myArr[dim1,dim2]);
    else System.Console.WriteLine($"Данный элемент в массиве отсутствует");
}
int m = GetNumber ("Введите размерность строки массива: ");
int n = GetNumber ("Введите размерность столбца массива: ");
int [,] newArr = GetArray(m,n);
PrintArray(newArr);
int m1 = GetNumber ("Введите индекс строки искомого элемента : ");
int n1 = GetNumber ("Введите индекс столбца искомого элемента : ");
GetValue(newArr, m1, n1);*/







