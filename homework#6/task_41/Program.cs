/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.Clear();
Console.Write("Введите требуемое количество чисел через пробел: ");
int[] n = (Console.ReadLine() ?? "").Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
int count = 0;
for (int i = 0; i< n.Length; i++)
    if (n[i] > 0)
        count++;
Console.WriteLine($"Количество чисел больше 0 составляет: " + count);

// Второй вариант решения
// Console.Write("Введите требуемое количество чисел через пробел: ");
// string str = Console.ReadLine() ?? " ";
// int[] n = Array.ConvertAll(str.Split(' '), int.Parse);
// int count = 0;
// for (int i = 0; i< n.Length; i++)
//     if (n[i] > 0)
//         count++;
// Console.WriteLine("Количество чисел больше 0 составляет: " + count);

