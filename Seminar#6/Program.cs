// Задача№1
// Напишите программу, которая перевернет одномерный массив
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int [] CreatNewArray (int size, int minVal, int maxVal)
{
    int [] firstArray = new int [size];
    for (int i = 0; i < size; i++)
        firstArray[i] = new Random().Next(minVal, maxVal+1);
    return firstArray;
}
void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

// 1 2 3 4 5                        -> startArray
// 0 1 2 3 4
//         меняем
// i = 0, 0 <-> 4  -> 5 2 3 4 1
// i = 1, 1 <-> 3  -> 5 4 3 2 1
// i = 2, 2 <-> 2  -> 5 4 3 2 1
// i = 3, 3 <-> 1  -> 5 2 3 4 1 
// i = 4, 4 <-> 0  -> 1 2 3 4 5

int [] ReversArray (int [] startArray)                 // (метод, чтобы перевернуть)
{
    int lenStAr = startArray.Length;                  // lenStAr = 5
    for (int i = 0; i < lenStAr/2; i++)               // i = 0; i > 2 (5/2); i++
    {
        int temp = startArray[i];                     // temp = startArray[0] = 1                                                   |
        startArray[i] = startArray[lenStAr - 1 -i];   // startArray = (lenStAr -1 - 0 (наш последний элемент)) => 5 -> (5 2 3 4 5)  | =>  5 2 3 4 1
        startArray[lenStAr - 1 -i] = temp;            // startArray(5 - 1 - 0) = 1   (доп метод(поменять))                          | 
    }
    return startArray;     
}

int sizeArray = 7;
int minimalVAl = 0;
int maximalVal = 9;

int [] newArray = CreatNewArray(sizeArray, minimalVAl, maximalVal);
PrintArray(newArray);
// int [] reversedArray = ReversArray(newArray);
// PrintArray(reversedArray);
//      или
PrintArray(ReversArray(newArray));
*/

// Задача№2
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: a и b (пользователь).
/*
// 0 1 0+1=1 1+1=2 1+2=3 2+3=5 (последовательности Фибоначчи) -> задано кол-во элементов N
// a b a+b=c b+c=d                                            -> задано первое и второе знач послед-ти a, b 
// 1. Запросить N, a, b
// 2. Убедитьcя, что наша N >= 2
// 3. Организовать цикл по модели Ивана
// 4. Вывести массив на печать
*/
/*
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

//                N          a           b
void ArrFib (int count, int first, int second)
{
    int [] fibArray = new int [count];
    fibArray[0] = first;
    fibArray[1] = second;
    for (int i = 2; i < count; i++)
    //                  предыдущее      2ое предыдущее
        fibArray[i] = fibArray[i - 1] + fibArray[i - 2]; 
   PrintArray(fibArray);
}

Console.WriteLine("input count of elements: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());
if (countOfElem < 2)
{
    while(countOfElem < 2)
    {
    Console.WriteLine("Impossible");
    Console.WriteLine("input count of elements");
    countOfElem = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("input 1st elements: ");
int first_el = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input 2st elements: ");
int second_el = Convert.ToInt32(Console.ReadLine());

 ArrFib(countOfElem, first_el, second_el);
*/

// Задача№3
// Напишите программу, которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длины,
// каждая сторона треугольника меньше суммы других сторон
//       0      1
// bool true, false
/*
bool Triangle (int side1, int side2, int side3)
{
    if (side1<side2+side3 && side2<side1+side3 && side3<side1+side2)
       return true;
    else return false;
}

Console.WriteLine("input 1st side: ");
int first_side = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input 2st side: ");
int second_side = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("input 3st side: ");
int third_side = Convert.ToInt32(Console.ReadLine());

bool result = Triangle(first_side, second_side, third_side);
if (result == true)
   Console.WriteLine("Triangle exist");
else
   Console.WriteLine("Triangle does't exist (((" );
*/

// Задача№4


/*
  10 |_2_
 _10_| 5 |_2_
  (0) _4_| 2 |_2_
      (1) _2_| 1 |_2_
          (0) _0_| 0
              (1)

десятичная      двоичная
   10       ->    1010
*/

// string result;
// b = a + result => a542,  b = result + a => 542a
/*
string BinarSyst (int num)               // Метод перевода в двоичную систему исчисление
{
    string binResult = string.Empty;  // (Создаем пустую строку)
    while (num != 0)                     // |
    {                                    // |
        binResult = num % 2 + binResult; // |  перевод на двоичную систему
        num /= 2;                        // |
    }                                    // |
    return binResult;                    // |
}
Console.WriteLine("input number: ");
int userNum = Convert.ToInt32(Console.ReadLine());

string res = BinarSyst(userNum);
Console.WriteLine($"your number {userNum} on bynar system is {res}");
*/




