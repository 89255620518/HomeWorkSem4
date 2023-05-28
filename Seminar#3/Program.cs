/*     
      |y
  II  |  I
      |
______!______x
      |
  III |  IV
      |

  I: x > 0; y > 0
 II: X < 0; y > 0
III: x < 0; y < 0
 VI: x > 0; y < 0
*/

// Задача№1
// Напишите программу, которая принимает на координаты точки(х и у), причем
// х = 0 и у = 0 и выдает номер четверти плоскости в которой находится эта точка.

/*
void Coordinate (int x, int y)
{
    if(x > 0 && y > 0)
        Console.WriteLine("This point on 1st quater");
    else if(x < 0 && y > 0)
        Console.WriteLine("This point on 2st quater");
    else if(x < 0 && y < 0)
        Console.WriteLine("This point on 3st quater");
    else
        Console.WriteLine("This point on 4st quater");  
}
// блок ввода данных
Console.WriteLine("input x: ");
int xCoords = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y: ");
int yCoords = Convert.ToInt32(Console.ReadLine());

// проверка органичений из условия задачи
if (xCoords == 0 || yCoords == 0)
   Console.WriteLine("its impossible value for this task!");
else
   Coordinate(xCoords, yCoords);
*/

// Задача№2
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (х и у).
/*
void PossibleValue(int num)
{
    if(num == 1)
       Console.WriteLine("1st quater x > 0; y > 0 ");
    else if(num == 2)
       Console.WriteLine("2st quater X < 0; y > 0 ");
    else if(num == 3)
       Console.WriteLine("3st quater x < 0; y < 0 ");
    else 
       Console.WriteLine("4st quater x > 0; y < 0 ");
}
Console.WriteLine("input number: ");
int nUm = Convert.ToInt32(Console.ReadLine());

if(nUm >= 1 && nUm <= 4)
   PossibleValue(nUm);
else
   Console.WriteLine("Its not number of quater!");
*/

// Задача№3
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// А(х1, у1), В(х2, у2)
// Math.Sqrt() - извлечение квадратного корня
//      _______________________________________
//    \/(х1 - х2)(x1 - x2) + (y1 - y2)(y1 - y2)

/*
double Longline (int x1, int x2, int y1, int y2)
{
    double lengthAB = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2));
    //double lengthAB1 = Math.Round(lengthAB, 2);                 // - Округление
    return lengthAB;
}

Console.WriteLine("input x1(A): ");
int xCoordsA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y1(A): ");
int yCoordsA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input x2(B): ");
int xCoordsB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input y2(B): ");
int yCoordsB = Convert.ToInt32(Console.ReadLine());

double dist = Longline(xCoordsA, yCoordsA, xCoordsB, yCoordsB);
Console.WriteLine($"->{dist:f3}");
*/

// Задача№4
// Напишите программу, которая принимает на вход число (N) и
// выдает таблицу квадратов чисел от 1 до N.
// Пример:
// 5 -> 1, 4, 9, 15, 25
// 2 -> 1, 4

/*
void Quater()
{
    Console.WriteLine("input number: ");
    int numberN = Convert.ToInt32(Console.ReadLine());
    if(numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)                   // Если значение положительное число
        {
            int res = current_i * current_i;
            Console.Write($" {res}, ");
            current_i++;
        }
        Console.WriteLine("\b\b.");          // Убирает в конце пробел и заменяет (,) на (.)
    }
    else
    {
        int current_i = 1;
        while (current_i >= numberN)
        {
            Console.Write(current_i*current_i + ", ");     // Если значение отрицательное число
            current_i--;
        }
        Console.WriteLine("\b\b."); 
    }
}
Quater();
*/




