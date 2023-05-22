// '32' 32
// string int (double, float)

// '32' + '78' = 3278
//  32  +  78  = 110
// Console.Write()          - Однострочная
// Console.WriteLine()      - Переходить на новую строку

// Console.Write("Good morning! ");
// Console.WriteLine("input your number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number}");

// Задача№1
//  Напишите программу, которая на вход принимает число и
//  выводить его квадрат.

// Console.WriteLine("input number: ");
// int nUm = Convert.ToInt32(Console.ReadLine());
// int temp = nUm * nUm;

// Console.WriteLine($"{nUm} -> " + (temp));

// Задача№2
// Напишите программу, которая принимает два числа и
// проверяет, что первое число является квадратом второго.

// 1. Запросить два знач.
// 2. Возвести 2ое число в квадрат
// 3. Проверить на равенство 1ому числу

// Console.WriteLine("input 1st number: ");
// int num_Ber1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("input 2st number: ");
// int num_Ber2 = Convert.ToInt32(Console.ReadLine());

// int temp = num_Ber2 * num_Ber2;

// if(num_Ber1 == temp)
// {
//     Console.WriteLine($"{num_Ber2} * {num_Ber2} = {num_Ber1} -> yes");
// }
// else
// {
//     Console.WriteLine($"{num_Ber2} * {num_Ber2} = {num_Ber1} -> no ");

// Задача№3
// Напишите программу, которая на вход принимает одно число N,
// а на выходе показывает все целые числа от -N до N.
/*
Console.WriteLine("input 1st number: ");
int number_N = Convert.ToInt32(Console.ReadLine());

int current_i = number_N * (-1);

while(current_i <= number_N)
{
    Console.Write(current_i + " ");
    current_i++;
}
*/

// Задача№4
// Напишите программу, которая принимает на вход трехзначное число и
// на выходе показывает последнюю цифру этого числа.

// 1. Ввод числа

// Console.WriteLine("input number: ");
// int num_N = Convert.ToInt32(Console.ReadLine());

// 2. Проверить на трехзначность  (N > 99 || N < 1000)
// 3. Выявить последнюю цифру: n % 10
    // 456 % 10  -> 6
    // 456 % 100 -> 56
    // 456 / 10  -> 45
    // 456 / 100 -> 4

/*
Console.WriteLine("input number: ");
int num_N = Convert.ToInt32(Console.ReadLine());

if(num_N > 99 && num_N < 1000)
{
    // int num_dev = num_N % 10;
    // Console.WriteLine($"{num_N} -> {num_dev}");
    Console.WriteLine($"{num_N} -> {num_N % 10}");
}
else
{
    Console.WriteLine("Your number is not 3-digits");
}
*/





