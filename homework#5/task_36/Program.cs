/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
// Решение задачи ДО семинара

void GetArr(int[] array) //Заполняет массив случайными трехзначными числами.
{
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = num.Next(-100,100);
}
void PrintArr(int[] array) //Выводит полученный массив на консоль.
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + (i < array.Length - 1 ? "," + " " : " "));
}
void GetSum(int[] array) // Определяет сумму элементов, стоящих на нечетных позициях массива.
{
    int sum = 0;
    for (int i = 1; i < array.Length;)
    {
        sum = sum + array[i];
        i += 2;
    }
System.Console.WriteLine();
System.Console.Write($"Сумма чисел, стоящих на нечетных позициях заданного массива, равна {sum}");
}
Console.Clear();
int[] myArr = new int [5];
GetArr(myArr);
PrintArr(myArr);
GetSum(myArr);


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
// Заполняет массив рандомными числами
int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-100, 100);
    }
    return array;
}
// Выводит полученный массив на консоль 
void PrintArr(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    System.Console.WriteLine();
}
int GetSum(int[] array) // Определяет сумму элементов, стоящих на нечетных позициях массива.
{
    int sum = 0;
    for (int i = 1; i < array.Length;)
    {
        sum = sum + array[i];
        i += 2;
    }
    return sum;
}
Console.Clear();
int dimension = GetNumber("Введите размерность массива:");
int[] array = InitArray(dimension);
PrintArr(array);
int sum = GetSum(array);
System.Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях заданного массива, равна {sum}");*/
