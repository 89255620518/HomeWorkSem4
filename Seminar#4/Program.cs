// цикл for используем, если мы знаем начальный индекс(index1), конечный индекс(index2) 
// и конкретный шаг(step):
// for (index1 ><=  ; index1 >< index2; step++);


// Задача№1
// Напишите программу, которая на вход принимает сумму чисел (А) и
// выдает от 1 до (А).
/*
void NumSum(int a)
{
    int sum = 0;
    for (int cur_i = 1; cur_i <= a; cur_i++)
    {
        sum += cur_i;    // sum = sum + cur_i
    }
    Console.WriteLine($"Sum of elements from 1 -> {a} = {sum}");
    
}
Console.WriteLine("input number: ");
int num_ber = Convert.ToInt32(Console.ReadLine());

if (num_ber >= 1)
{
    NumSum(num_ber);
}
else
{
    Console.WriteLine("Error");
}
*/

// Задача№2
// Напишите программу, которая принимает на вход число и
// выдает количество цифр(разрядов) в числе.
// Пример:
// 789   -> 3
// 45542 -> 5
 /*
int CountOfDigits (int number)              // 456
{
    int countDigits = 1;                    //  1
    while (number >= 10)                    // 456 >= 10(yes)        45 >= 10(yes)        4 >= 10(no)
    {
        number = number / 10;               // 456 / 10    -> 45        45 / 10  -> 4      
        countDigits++;//(кол-во разрядов)   countDigits -> 2      countDigits -> 3
    }

    return countDigits;
}

Console.WriteLine("input number: ");
int res = Convert.ToInt32(Console.ReadLine());

if (res >= 0 )
{
   Console.WriteLine($"{res} -> {CountOfDigits(res)}");
}
else
{
    Console.WriteLine($"{res} -> {CountOfDigits(res*(-1))}" );
}
*/

// Задача№3
// Напишите программу, которая принимает на вход число N и
// выдает произведение чисел от 1 до N.
// 0! = 1
/*
void MultipleFinder(int n)
{
    int multi = 1;
    for (int cur = 1; cur <= n; cur++)
    {
        multi *= cur;
    }
    Console.WriteLine($"{n} -> {multi}");
}
Console.WriteLine("input number: ");
int num_ber = Convert.ToInt32(Console.ReadLine());

if (num_ber <= 0)
{
    while(num_ber <= 0)
    {
        Console.WriteLine("Enter positive number: ");
        num_ber = Convert.ToInt32(Console.ReadLine());
    }
}
MultipleFinder(num_ber);
*/

// Задача№4
// Напишите программу, которая выдает массив из 8 элементов,
// заполненные нулями и единицами в случайном порядке.
// Пример:
// (1, 0, 1, 1, 0, 1, 0, 0)

// индексы:                0  1  2  3  4
// размер массива:         5
// знач. элемента массива: 87 12 9 -7 50
/*
int [] CreatNewArray (int size, int min, int max) // метод создания метода
{
    int [] array = new int[size]; // int(1)-тип данных массив, []-массив, new - выделение памяти, int[размера массива]
    for(int i = 0; i < size; i++)
    {
        // array[i] - значение элемента в массиве (array) на позиции (i)
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray (int [] array)   // демонстрация массива
{
    for(int i = 0; i < array.Length; i++) // .Length - считает коль-во элементов в существующем массиве
        Console.Write((array[i]) + "  ");
}

Console.WriteLine("input count of element: ");
int num = Convert.ToInt32(Console.ReadLine());

int minVal = 0;
int maxVal = 1;

int [] array1 = CreatNewArray(num, minVal, maxVal);
ShowArray(array1);
*/




