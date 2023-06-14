// Задача№1
// Задайте зн N. Напишите программу,
// которая выведет все натуральные числа в промежуток от 1 до N
/*
void ShowNum (int numbers)
{
    if (numbers > 1)
    {
       ShowNum(numbers - 1);  // вызываем метод для др. знач. (-1) для рекурсии очень важно
    }
    Console.Write(numbers + " ");
}
ShowNum(5);
*/

// Задача№2
// Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр. 
/*
int SumDogit(int num) // метод для разбора числа на цифры
{
   if (num < 0)
   {
      num *= -1;
   }
   if (num > 0)
   {                                           // 987 -> 98 -> 9 -> 0
      return SumDogit(num/10) + num % 10; // (num/10) = 98, num % 10 = 7
   }                                           // 
   else
   {
      return 0;
   }
}
int res = SumDogit(-987);
Console.Write(res);
*/

// Задача№3
// Напишите программу, которая на вход принимает два A и B?
// и возводит число А в целую степень В с помощью рекурсии.
// 2^3 = 2 * 2 * 2  = 8
// 2^(-3) = 1 / (2^3)  = 1/8
// 22^(-3) = 1/22 *  1/22  * 1/22 = 1/8
// -2 ^ 3 = -8
// -2 ^ 4 = 16
/*
double Squart (int num_A, int num_B)
{
    if (num_B > 0) return Squart(num_A, num_B - 1)*num_A;
    if (num_B < 0) return Squart(num_A, num_B + 1)/num_A;
    else return 1.0;
}

double resPow = Squart(0,0);
Console.Write(resPow);
*/






