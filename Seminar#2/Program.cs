// int data = 24;
// Console.WriteLine("Good morning! Today is " + data + " april");
// Console.WriteLine($"Good morning! Today is {data} april");

// Задача№1
// Напишите программу, которая получает на вход двухзнач число и
// показывает наибольшую цифру числа.
/*
int Usr (int number)         // возвратный метод
{
    // 1. Выделить цифры
    int ed = number % 10;
    int dec = number / 10;

    // 2. Сравниваем цифры

    if (ed > dec)
    {
        return ed;
    }
    else
    {
        return dec;
    }

    // 3. Результат
}
*/
/*
void Usr1 (int number)          // НЕвозвратный метод
{
   // 1. Выделить цифры
    int ed = number % 10;
    int dec = number / 10;
     if (ed > dec)
    {
        Console.WriteLine("The biggest digit is " + ed);
    }
    else
    {
        Console.WriteLine("The biggest digit is " + dec);
    }
    // 3. Результат
}
*/

/*
// вызываем наш метод
Console.WriteLine("input number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

if(user_num > 9 && user_num < 100)
{ 
   // Usr1(user_num);                                       // Для НЕвозвратной 
    //int res = Usr1(user_num);                           // для возвратной
   // Console.WriteLine($"The biggest digit is {res}");
}
else
{
    Console.WriteLine("Impossible value: ");
}
*/

// Задача №2
// Напишите программу, которая выводит случайное число из отрезка [10, 99] и
// показывает наибольшую цифру числа.

/*
void Usr1 (int number)                                              // метод сравнение разрядов
{
   // 1. Выделить цифры
    int ed = number % 10;
    int dec = number / 10;
     if (ed > dec)
    {
        Console.WriteLine($" The biggest digit is: {ed}");
    }
    else if (ed == dec)
    {
        Console.WriteLine("The digit are equal");
    }
    else
    {
        Console.WriteLine(" The biggest digit is " + dec);
    }
    // 3. Результат
}

void Big_num ()                                                     // 1. невозвратный метод( без аргументов )
{
    int minVal = 10;
    int maxVal = 99;
    int randomNum = new Random().Next(minVal, maxVal + 1);  // 2. генератор
    Console.WriteLine("Your number is " + randomNum);        // Cгенерированное значение
  
    Usr1(randomNum);                                        // вызываем метод сравнение разрядов
}
Big_num();                                                          // Вызываем метод
*/

// Задача№3
// Напишите программу, которая принимает на вход число и
// проверяет, кратно ли оно одновременно а и b.

// кратно:
// 21 : 3 = 7,0  (0) - это остаток (кратно)
// 21 : 7 = 3,0  (0) - это остаток (кратно)
/*
void Cratnost(int a, int b, int num)            // метод проверки на кратность
{
    if(num % a == 0 && num % b == 0)  // проверка на кратность двум значением
    {
        Console.WriteLine($"your number {num} is multiple {a} and {b}");
    }
    else
    {
        Console.WriteLine($"your number {num} is not multiple {a} and {b}");
    }
}
// Запрос данных у пользователя
Console.WriteLine("input number: ");                // Запрос самого числа
int user_num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input 1st number: ");            // Запрос 1ого делителя
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input 2st number: ");            // Запрос 2ого делителя
int num_b = Convert.ToInt32(Console.ReadLine());

Cratnost(num_a, num_b, user_num);               // Вызов метода
*/

// Задача№4
// Напишите программу, которая выводит случайное 3х значное число и
// удаляет вторую цифру этого числа.
// Пример:
// 456 -> 46, 769 -> 79
/*
int Numer()
{
    int randomNum = new Random().Next(100, 1000);      // 2. генератор
    Console.Write("Your number is: " + randomNum); 

    int digit1 = randomNum / 100;   // 456 / 100 -> 4
    int digit2 = randomNum % 10;    // 456 % 10  -> 6
    
    int digit = digit1 * 10 + digit2;
    return digit;
}

Console.Write($" -> {Numer()}");
*/