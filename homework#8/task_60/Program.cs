/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
// Пишем метод проверки на число
// Пишем метод инициализации (заполнения массива) по введенным параметрам длин составных массивов (х, y, z) с проверкой и устранением повторений
// Выводим массив на консоль

// Проверка на число
int GetNumber(string message)
{
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else Console.WriteLine("Введено недопустимое значение! Повторите ввод!");
    }
    return result;
}

// Заполнение массива случайными неповторяющимися числами
int[,,] InitArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rnd = new Random();
    bool Unique(int randomNumber)
    {
        for (int i = 0; i < x; i++)
            for (int j = 0; j < y; j++)
                for (int k = 0; k < z; k++)
                    if (array[i, j, k] == randomNumber)
                        return true;
        return false;
    }
    for (int i = 0; i < x; i++)
        for (int j = 0; j < y; j++)
            for (int k = 0; k < z; k++)
            {
                int uniqNum;
                do
                {
                    uniqNum = rnd.Next(10, 100);
                } while (Unique(uniqNum));
                array[i, j, k] = uniqNum;
            }
    return array;
}
// Вывод на консоль 
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
    System.Console.WriteLine($"\n");
}

int x = GetNumber("Введите размерность х массива: ");
int y = GetNumber("Введите размерность y массива: ");
int z = GetNumber("Введите размерность z массива: ");
int[,,] myArray = InitArray(x, y, z);
PrintArray(myArray);

