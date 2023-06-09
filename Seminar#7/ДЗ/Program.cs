// Задача№47
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5   7   -2  -0,2
//  1  -3,3   8  -9,9
//  8   7,8 -7,1   9
/*
double [,] Doubble2DArray (int row, int columb, int minVal, int maxVal)
{
    double [,] doublesArray = new double[row, columb];
    for(int i = 0; i < row; i++)
       {
        for (int j = 0; j < columb; j++)
        {
            int digit = new Random().Next(minVal, maxVal);
           double doubleDigit = new Random().NextDouble();
           doublesArray[i, j] = Math.Round((digit + doubleDigit), 2);
        }
       }
    return doublesArray;
}

void Show2Darray (double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
       {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
       }
    Console.WriteLine();
}

Console.WriteLine("input count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columbs: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

double [,] array2D = Doubble2DArray (m, n, minV, maxV);
Show2Darray(array2D);
*/



// Задача 50. Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
/*
int [,] Creat2DArray (int rows, int columb, int min, int max)
{
    int [,] creatAr = new int [rows, columb];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columb; j++)
        {
            creatAr[i,j] = new Random().Next(0, 9);
        }
    }
    return creatAr;
}

void Print2DArray (int [,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
           {
             Console.Write(array[i, j] + " ");
           }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.WriteLine("input count of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columbs: ");
int columb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] array2D = Creat2DArray(row, columb, minV, maxV);
Print2DArray(array2D);

if (row < array2D.GetLength(0) && columb < array2D.GetLength(1)) Console.WriteLine(array2D[row, columb]);
else Console.WriteLine($"{row}{columb} -> такого числа в массиве нет");
*/

// Задача№52
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3
/*
int [,] Creat2Darray (int rows, int columbs, int min, int max)
{
    int [,] creat2D = new int [rows, columbs];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columbs; j++)
        {
            creat2D[i, j] = new Random().Next(min, max);

        }
    }
    return creat2D;
}

void Show2Dar (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
       for (int j = 0; j < array2D.GetLength(1); j++)
       {
           Console.Write(array2D[i, j] + " ");
       }
       Console.WriteLine();
    }
    Console.WriteLine();
}

void Sum (int [,] num)
{
for (int j = 0; j < num.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < num.GetLength(0); i++)
    {
        sum += num[i, j];
    }
    Console.Write($"{ sum / num.GetLength(0)}; ");
}
Console.WriteLine("\b\b.");
Console.ReadLine();
}



Console.WriteLine("input count of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columbs: ");
int columb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] res2Darray = Creat2Darray(row, columb, minV, maxV);
Show2Dar(res2Darray);
Sum(res2Darray);
*/


