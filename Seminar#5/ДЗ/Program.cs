// Задача 34:
//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Пример:
// [345, 897, 568, 234] -> 2
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

void SumNum (int [] numbers)     //  нахождение четных чисел
{
int count = 0;

for (int i = 0; i < numbers.Length; i++)   
if (numbers[i] % 2 == 0) 
count++;

Console.Write($"Всего {numbers.Length} чисел, {count} из них чётные");
}

int sizeStart = 15;
int minPosVal = 99;
int maxPosVal = 999;

int [] arrayStart = CreateRanArraq( sizeStart, minPosVal, maxPosVal);
ShowArray(arrayStart);
SumNum(arrayStart);
*/

// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

void  SumOdd (int [] num)
{
    int count = 0;

    for (int i = 0; i < num.Length; i++)
    count = count + num[i];
    Console.WriteLine($"всего {num.Length} чисел, сумма элементов на нечётных позициях = {count}");
}

int sizeStart = 15;
int minPosVal = 9;
int maxPosVal = 99;

int [] ArrayI = CreateRanArraq(sizeStart, minPosVal, maxPosVal);
ShowArray(ArrayI);
SumOdd(ArrayI);
*/

// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// Пример:
// [3 7 22 2 78] -> 76
/*
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

double count = max - min;
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {count}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
*/



