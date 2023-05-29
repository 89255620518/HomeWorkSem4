// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// Пример:
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
void NumFinder(int a, int b)
{
    int step = a;
    for (int i = 1; i < b; i++)
    {
        step = step * a;
    }
    Console.WriteLine($"({a}, {b}) -> {step}");
}
Console.WriteLine("input number A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number B");
int numB = Convert.ToInt32(Console.ReadLine());
NumFinder(numA, numB);
*/


// Задача 27
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Пример:
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
// Функция ввода
int NumSum(string num)
{
    Console.WriteLine(num);
    int num_ber = Convert.ToInt32(Console.ReadLine());
    return num_ber;
}


// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int numA = len;
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($" -> {sum}");
}
int number = NumSum("input number: ");
int len = NumberLen(number);
SumNumbers(number, len);
*/


// Задача 29:
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Пример:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write((randomArray[i]) + " ");
}


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/


