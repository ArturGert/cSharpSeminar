/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/
//Решение задачи ДО семинара
void GetArr(int[] array) //Заполняет массив случайными трехзначными числами
{
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
    array[i] = num.Next(100,1000); // от 100 до 999
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

//Решение задачи ПОСЛЕ семинара
/*
//Проверка на число
int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}
//получить заполненный массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}
//Выводит полученный массив на консоль 
void PrintArr(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}
// Определяет количество четных чисел в массиве
int GetCount (int[] myArr) 
{
    int count = 0;
    for (int i = 0; i < myArr.Length; i++)

    if (myArr[i] % 2 == 0)
        count ++;
    return count;
}

Console.Clear();
int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArr(array);
int count = GetCount(array);
System.Console.WriteLine($"Количество четных чисел в заданном массиве составляет {count}");*/
