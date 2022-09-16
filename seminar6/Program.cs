// *Задача 39:** Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int [] myArr =  {1, 2, 3, 4, 5};

void ChangeArr (int [] arr)
{
    int help = 0;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        help = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = help;
    }
}

void PrintArr (int [] arr) 
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
    Console.WriteLine();
}

// PrintArr(myArr);
// ChangeArr(myArr);
// PrintArr(myArr);


// **Задача 40:** Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// <aside>
// ❗ **Теорема о неравенстве треугольника:** каждая сторона треугольника меньше 
// суммы двух других сторон.
// </aside>

Console.WriteLine("Введите длинну первой стороны");
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите длинну первой стороны");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длинну первой стороны");
int c = Convert.ToInt32(Console.ReadLine());

int count = 0;
if (a < b + c) count+=1;
if (b < a + c) count+=1;
if (c < b + c) count+=1;

if (count == 3) Console.WriteLine("Такой треугольник может существовать.");
else Console.WriteLine("Таких треугольников не бывает.");




// **Задача 42:** Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int numZ = Convert.ToInt32(Console.ReadLine());
int [] numZArr = new int[8];
for (int i = 0; i < numZArr.Length; i++ )
{   
    numZArr[i] = numZ % 2;
    numZ = numZ / 2;
}

PrintArr(numZArr);
ChangeArr(numZArr);
PrintArr(numZArr);

// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
void Fibonacci (int N)
{
    int fibo = 0;
    int a = 0;
    int b = 1;
    Console.Write($"{a} {b} ");
    for (int i = 0; i <= N - 3; i++)
    {
        fibo =  a + b;
        Console.Write($"{fibo} ");
        a = b;
        b = fibo;
    }
    Console.WriteLine();
}

Fibonacci(5);
Fibonacci(7);