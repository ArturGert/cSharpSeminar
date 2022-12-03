Console.Clear();
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int ThNumber = 0; 
int ThirdDigit = 0;
if (N>=100)
{
    while (N>=1000) 
    ThNumber = (N /= 10);
    ThirdDigit = (ThNumber %10);
    Console.Write($"Третья цифра заданного числа: {ThirdDigit}"); 
}
else Console.Write("В введенном числе 3-я цифра отсутствует");