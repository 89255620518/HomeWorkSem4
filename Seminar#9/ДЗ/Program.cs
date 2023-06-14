// Задача 64: 
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void Rec (int n)
{
    Console.Write(n + " ");
    if(n > 1)  Rec(n - 1);
}
Rec(8);
*/


// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumNat (int m, int n, int sum)
{
    if (m > n)
    {
        
        return sum;
    }
    sum = sum + (m++);
    return SumNat(m, n, sum);
    
}

Console.WriteLine("input number M: ");
int num_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number N: ");
int num_N = Convert.ToInt32(Console.ReadLine());

int numbers = SumNat(num_M, num_N, 0);
Console.WriteLine($"M = {num_M}; N = {num_N} -> {numbers}");
*/



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int NumAker (int m, int n)
{
    if (m == 0) return  n+1;
    else if (m > 0 && n==0) return NumAker(m-1, 1);
    else  return NumAker(m-1, NumAker(m, n-1));
}

Console.WriteLine("input number M: ");
int num_M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input number N: ");
int num_N = Convert.ToInt32(Console.ReadLine());

int numSum = NumAker(num_M, num_N);

Console.WriteLine($"{num_M}, {num_N} -> {numSum}");
*/
