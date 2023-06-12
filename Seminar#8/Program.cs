// Задача№1
// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int [,] Creat2Darray (int rows, int cols, int min, int max)
{
    int [,] creat2D = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            creat2D[i, j] = new Random().Next(min, max+1);
        }
           
    }
    return creat2D;
}

void Show2Dar (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] ChangeArrayRows (int [,] array)                     // метод, чтобы менять местами строки
{
    Console.Write("input first row number: ");
    int row1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("input second row number: ");
    int row2 = Convert.ToInt32(Console.ReadLine());
    
    if (row1>=0 && row1<array.GetLength(0) && row2>=0 && row2<array.GetLength(0))
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1,j] = array[row2,j];
            array[row2,j] = temp;
        }
        return array;
    }
    else
    {
        Console.WriteLine("incorrect data");
        ChangeArrayRows(array);
        return array;
    }
}

Console.WriteLine("input count of rows: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columbs: ");
int columb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxV = Convert.ToInt32(Console.ReadLine());

int [,] res2DArray = Creat2Darray(row, columb, minV, maxV);
Show2Dar(res2DArray);
int [,] change = ChangeArrayRows(res2DArray);
Show2Dar(change);
*/

// Задача№2
// Задайте двумерный массив.
// Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести 
// сообщение для пользователя.
/*
int [,] Array2D (int rows, int cols, int min, int max)
{
    int [,] array2D = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < cols; j++)
        array2D[i,j] = new Random().Next(min, max+1);
    } 
    return array2D;
}

void Print2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int [,] Change2D (int [,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
        return array;
    }
    else
    {
        Console.WriteLine("incorrect value");
        return array;
    }
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
Print2DArray(res2DArray);
Console.WriteLine();

int [,] change = Change2D(res2DArray);
Print2DArray(change);
*/

// Задача№3
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая занулит строку и столбец,
// на пересечения которых расположен наименьший элемент массива.
/*
int [,] Crear2Dar (int rows, int cols, int min, int max)
{
    int [,] creat = new int [rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            creat[i, j] = new Random().Next(min, max);
        }
    }
    return creat;
}

void Show2Dar (int [,] array)
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

int [,] NullRowsCols (int [,] array)                 // Метод, которая занулит строку и столбец
{
    int i_min = 0;
    int j_min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[i_min, j_min])
            {
                i_min = i;
                j_min = j;
            }
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i_min, j] = 0;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i, j_min] = 0;
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

int [,] res2DArray = Crear2Dar(row, columb, minV, maxV);
Show2Dar(res2DArray);
Console.WriteLine();

int [,] nulls = NullRowsCols(res2DArray);
Show2Dar(nulls);
*/


