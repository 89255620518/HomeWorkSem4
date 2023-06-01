// Задача№1
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
/*
//                        размер
int [] CreateRanArraq (int size, int minVal, int maxVal) // метод создания массива размера size со значениями от minVal, maxVal
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for(int i = 0; i < array1.Length; i++)
       Console.Write(array1 [i] + " ");
    Console.WriteLine();
}

int FindSumNegative (int[] array)
{
    int sumNegative = 0;                   // - отрицательные
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNegative += array[i];
        }
    }
    return sumNegative;

}

int FindSumPositive (int[] array)
{
    int sumPositive = 0;                   // - Положительные
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPositive += array[i];
        }
    }
    return sumPositive;

}

int sizeArray = 12;
int minVal    = -9;
int maxVal    =  9;

int [] createdArray = CreateRanArraq(sizeArray, minVal, maxVal);
ShowArray(createdArray);  // показать массив
Console.WriteLine($"Sum of positive elem. is {FindSumPositive(createdArray)}");
int resultNegative = FindSumNegative(createdArray);
Console.WriteLine($"Sum of negative elem. is {resultNegative}");
*/

// задача№2
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и посл. элемент, второй и предпоследний.
// Результат напишите в новом массиве
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]   -> 36 21

/*
int [] CreateRanArraq (int size, int minVal, int maxVal) // метод создания массива размера size со значениями от minVal, maxVal
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for(int i = 0; i < array1.Length; i++)
       Console.Write(array1 [i] + " ");
    Console.WriteLine();
}

int [] FindMultiPar (int [] arrayFormulti)
{
    int sizeTemp; //длина массива с произведениями
    if ( arrayFormulti.Length % 2 == 0)
       sizeTemp = arrayFormulti.Length / 2;
    else sizeTemp = (arrayFormulti.Length +1) / 2;

    int [] arrayMulti = new int [sizeTemp]; // 2. Массив для вывода результатов умножения
    
    for (int i = 0; i < arrayFormulti.Length / 2; i++) // для парных значений производим умножение
    {
        arrayMulti[i] = arrayFormulti[i] * arrayFormulti[arrayFormulti.Length - 1 - i]; //3. Запомнить массив произведениями [i] * (size_finish - 1 - 1) 
    }                                                                                   // [0] * [4]  [1] * [3]
    if (arrayFormulti.Length % 2 != 0)   // если в исходном массиве НЕчетное кол-во элементов, то
       arrayMulti[sizeTemp - 1] = arrayFormulti[sizeTemp - 1];  // в конечный массив на посл. позицию написать элемент из исходного
    return arrayMulti;
}

// Создаем переменные
int sizeStart     = 5;   // размер массива исх
int minPossibleVal = 1;  // мин. знач. для генерации
int maxPossibleVal = 9;  // макс. знач для генерации

int [] arrayStart =  CreateRanArraq(sizeStart, minPossibleVal, maxPossibleVal); // Создали массив рандомный
ShowArray(arrayStart); // продемонстрировали массив исходный
int [] arrayFinish = FindMultiPar(arrayStart); // создали и заполнили массив с результатом умножения
ShowArray(arrayFinish); // продемонстрировали массив с умножением


// 1. длина массива с произведениями size_start четное, то size_finish = size_start / 2
// size_start нечетное, (size_start + 1)/2
// 2. Массив для вывода результатов умножения 
// 3. Запомнить массив произведениями [i] * (size_start - 1 - 1) 
// 4. проверить запись особого этлеиента
*/

// задача№3
// Задайте одномерный массив из 123 случайных чисел.
// Найдите кол-во элементов массива, знач которых лежат в отрезке [10, 99].
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
// [5, 18, 123, 6, 2]   -> 1
// [1, 2, 3, 6, 2]      -> 0
// [10, 11, 12, 13, 14] -> 5

/*
int [] CreateRanArraq (int size, int minVal, int maxVal) // метод создания массива размера size со значениями от minVal, maxVal
{
    int [] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal+1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for(int i = 0; i < array1.Length; i++)
       Console.Write(array1 [i] + " ");
    Console.WriteLine();
}

void Count1099 (int [] arrayForFind)
{
   int count = 0;
   for (int i = 0; i < arrayForFind.Length; i++)
       if (arrayForFind[i] >= 10 && arrayForFind[i] <= 99)
          count++;
   Console.WriteLine($"ciunt of 2digits elements is {count}");
}

int sizeStart = 123;
int minPosVal = 1;
int maxPosVal = 999;

int [] arrayStart = CreateRanArraq(sizeStart, minPosVal, maxPosVal);
ShowArray(arrayStart);
Count1099(arrayStart);
*/





