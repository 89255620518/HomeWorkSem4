// Задача54:
// Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы 
// каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2       7 4 2 1
// 5 9 2 3  -->  9 5 3 2
// 9 5 3 2       8 4 4 2
/*
int [,] Array2D (int row, int cols, int min, int max)
{
    int [,] ar_ray = new int [row, cols];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            ar_ray[i, j] = new Random().Next(min, max);
        }
    }
    return ar_ray;
}

void Show2Ar (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] Change2Drow (int [,] array)    // Метод, чтобы упорядочить по убыванию элементы строки
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1)-1; k++)
            {
                if (array[i, k] < array[i, k+1])
                {
                   int temp = array[i, k+1];
                   array[i, k+1] = array[i, k];
                   array[i, k] = temp;
                }
            }
        }
    }
        return array;
}

Console.WriteLine("input count of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columbs: ");
int columb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] res2DArray = Array2D(row, columb, minV, maxV);
Show2Ar(res2DArray);
Console.WriteLine();

int [,] change = Change2Drow(res2DArray);
Show2Ar(change);
*/


// Задача 56: 
// дайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.За
// Например, задан массив:
// 1 4 7 2  -\
// 5 9 2 3  --\  1ая строка
// 8 4 2 4  --/
// 5 2 6 7  -/
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int [,] Array2D (int row, int cols, int min, int max)
{
    int [,] ar_ray = new int [row, cols];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            ar_ray[i, j] = new Random().Next(min, max);
        }
    }
    return ar_ray;
}

void Show2Ar (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumLineElements(int[,] array, int i)       // Метод нахождение суммы строки
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
  }
  return sum;
}

Console.WriteLine("input count of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columbs: ");
int columb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] res2DArray = Array2D(row, columb, minV, maxV);
Show2Ar(res2DArray);
Console.WriteLine();
int minSum = 0;
int sum = SumLineElements(res2DArray, 0);
for (int i = 1; i < res2DArray.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(res2DArray, i);
  if (sum > tempSumLine)
  {
    sum = tempSumLine;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой ({sum}) элементов ");
*/

// Задача 58: 
// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
/*
int [,] Array2D_1 (int row, int cols, int min, int max)
{
    int [,] ar_ray1 = new int [row, cols];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            ar_ray1[i, j] = new Random().Next(min, max);
        }
    }
    return ar_ray1;
}

int [,] Array2D_2 (int row, int cols, int min, int max)
{
    int [,] ar_ray2 = new int [row, cols];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            ar_ray2[i, j] = new Random().Next(min, max);
        }
    }
    return ar_ray2;
}

void Show2Ar (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMultiPar (int [,] array1, int [,] array2, int [,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1.GetLength(1); k++)
      {
        sum += array1[i,k] * array2[k,j];
        
      }
      result[i,j] = sum;
      //Console.WriteLine(sum + " ");
    }
    
  }
  
}

Console.WriteLine("Введите число строк 1-й матрицы:  ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int colsRow2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число столбцов 2-й матрицы: ");
int cols2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"1ая матрица");
int [,] array_1 = Array2D_1(row, colsRow2, minV, maxV);
Show2Ar(array_1);
Console.WriteLine("2ая матрица");
int [,] array_2 = Array2D_2(colsRow2, cols2, minV, maxV);
Show2Ar(array_2);

int [,] result = new int [row, cols2];

FindMultiPar(array_1, array_2, result);
//Console.WriteLine(" ");
Show2Ar(result);
*/



// Задача 60. ...
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
/*
int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"{array3D[i,j,k]}{(i, j, k)} ");
      }
      Console.WriteLine();
    }
  }
}

void CreateArray(int[,,] array3D)  // метод, построчно выводить массив, 
                                   // добавляя индексы каждого элемента.
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}

Console.WriteLine($"Введите размер массива X x Y x Z: ");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($" ");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
/*
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
*/







