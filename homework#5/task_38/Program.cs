/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
void GetArr (double[] array)  //Заполняет массив вещественными числами
{
    Random num = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(num.NextDouble() * (100-1), 2);
}
void PrintArr (double[] array)  // Выводит массив в консоль
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write(array[i] + (i < array.Length - 1 ? ";" + " " : ""));    
}
void GetDiff(double[] array) // Считает разницу между максимальным и минимальным элементами заданного массива
{
    double maxValue = array[0];
    double minValue = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue)
        {
            maxValue = array[i];
        } 
        if (array[i] < minValue)
        {
            minValue = array[i];
        }         
    }
    diff = Math.Round((maxValue - minValue), 2);
    System.Console.WriteLine();
    System.Console.Write($"Разница между максимальным и минимальным элементами заданного массива составляет: {diff}");
}
Console.Clear();
double[] myArr = new double [5];
GetArr(myArr);
PrintArr(myArr);
GetDiff(myArr);
