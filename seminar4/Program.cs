// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число:");
int numZ = Convert.ToInt32(Console.ReadLine());
int result = 0;
for (int i = 1; i <= numZ; i++)
{
    result = result + i;
}
Console.WriteLine(result);

// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите число:");
int numX = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (numX > 0)
{
    numX = numX / 10;
    count++;
}
Console.WriteLine(count);


// Задача 28: Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Введите число:");
int numY = Convert.ToInt32(Console.ReadLine());
int productNumbers = 1;
for (int i = 1; i <= numY; i++)
{
    productNumbers = productNumbers * i;
}
Console.WriteLine(productNumbers);

// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int num = new Random().Next(100,1000);
// int [] arr = {};
for (int i = 0; i < 8; i++)
{
    int num = new Random().Next(0,2);
    Console.Write($"{num} ");
}

// int [] MyArr  = {2, 4, 56, 76};
// Console.WriteLine(MyArr);
