/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
void GetArr (double[] array)  //Заполняет массив вещественными числами
{
for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100,100);
}
void PrintArr (double[] array)  // Выводит массив в консоль
{
for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + (i < array.Length - 1 ? "," + " " : ""));    
}
void GetDiff(double[] array) // Считает разницу между максимальным и минимальным элементами заданного массива
{
    double maxValue = 0;
    double minValue = 0;
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        }
        else if (array[i] == maxValue)
        {
            maxValue = array[i];
        }
        else minValue = array[i];
    diff = maxValue - minValue;
    }
    System.Console.WriteLine();
    System.Console.Write($"Разница между максимальным и минимальным элементами заданного массива составляет: {diff}");
}
Console.Clear();
double[] myArr = new double [5];
GetArr(myArr);
PrintArr(myArr);
GetDiff(myArr);
