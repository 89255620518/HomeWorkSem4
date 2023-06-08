// Задача№1
// Задайте двумерный массив размером (m)x(n), заполненный случайными целыми числами.
// m = 3, n = 4.
// 1  3  8 19
// 5 -2 33 -2
// 77 3  8  1
/*
int [,] CreatedArray ()                                              // создание двухмерного массива
{
    Console.WriteLine("input count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("input count of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("input min: ");
    int minVal = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("input max: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    
    int [,] create2Array = new int [rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            create2Array[i, j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return create2Array;
}

void PrintArray (int [,] array2d)                                    // Вывод пользователя 2мерного массива
{
    for (int i = 0; i < array2d.GetLength(0); i++)        // Вывод по номеру строки
    {
        for (int j = 0; j < array2d.GetLength(1); j++)    // заполнение внутри строки по столбцам
        {
            Console.Write(array2d[i,j] + " ");                // печать конкретного элем. массива
        }
        Console.WriteLine();                                         // переход вывода на новую строку массива
    }
    Console.WriteLine();                                             // отступ от самого массива
   
}

int [,] new2dArray = CreatedArray();
PrintArray(new2dArray);
*/

// Задача№2
// Задайте двумерный  массив размера (m) на (n), каждый элемент в массиве находится по формуле:
// Аmn = m+n, Выведите полученный массив на экран.
// m = 3, n = 4
// 0 1 2 3    [0,0] [0,1] [0,2] [0,3]
// 1 2 3 4    [1,0] [1,1] [1,2] [1,3]
// 2 3 4 5    
/*
int [,] FillArray2D ()
{
    Console.WriteLine("input count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());

     Console.WriteLine("input count of columbs: ");
    int userColumbs = Convert.ToInt32(Console.ReadLine());
    
    int [,] fill2DAr = new int [userRows, userColumbs];

    for (int i = 0; i < userRows; i++)
    {
        for (int j = 0; j < userColumbs; j++)
           fill2DAr[i, j] = i + j;
    }
    return fill2DAr;
}

void Print2DArray (int [,] ar2)
{
    for (int i = 0; i < ar2.GetLength(0); i++)
    {
        for (int j = 0; j < ar2.GetLength(1); j++ )
        {
            Console.Write(ar2[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] secondTaskArray = FillArray2D();
Print2DArray(secondTaskArray);
*/

// Задача№3
// Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса четные,
// и замените их элементы на их квадраты.
/*
double [,] Create2DArray (int row, int columb, int minV, int maxV)     // метод вызова двойного массива 
{
    double [,] create2Dar = new double [row, columb];
    for (int i = 0; i < row; i++)
       for (int j = 0; j < columb; j++)
       {
            int digit = new Random().Next(minV, maxV);
           double doubleDigit = new Random().NextDouble();
           create2Dar[i, j] = Math.Round((digit + doubleDigit), 2);
       }
       return create2Dar;
}

void Show2Darray (double [,] array2D)                                  // метод демонстрации
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
       for (int j = 0; j < array2D.GetLength(1); j++)
          {
            Console.Write(array2D[i,j] + " ");
          }
          Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] Change2Darray (double [,] arrayToChange)                    // метод возведение в квадрат
{
    for (int i = 0; i < arrayToChange.GetLength(0); i++)
    {
        for (int j = 0;j < arrayToChange.GetLength(1); j++)  
        {
            if (i % 2 != 1 && j % 2 != 1)
            {       
                arrayToChange[i, j] = Math.Round(Math.Pow(arrayToChange[i, j], 2), 2);
            } // Math.Round() - округление, Math.Pow() - возведение в степень
        }
    }   
    return arrayToChange;
}

Console.WriteLine("input count of rows: ");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input count of columb: ");
int userColumbs = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input min: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input max: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

double [,] createArray = Create2DArray(userRows, userColumbs, minVal, maxVal);
Show2Darray(createArray);
double [,] change2Darr = Change2Darray(createArray);
Show2Darray(change2Darr);
*/


