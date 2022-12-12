/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void GetArr(int[] array) //Заполняет массив случайными трехзначными числами.
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
}
void PrintArr(int[] array) //Выводит полученный массив на консоль.
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + (i < array.Length - 1 ? "," + " " : " "));
    }
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
int[] myArr = new int [10];
GetArr(myArr);
PrintArr(myArr);
GetSum(myArr);
