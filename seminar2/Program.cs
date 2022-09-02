// int num = new Random().Next(10,100);

// int n1 = num / 10;
// int n2 = num % 10;

// if (n1 > n2) 
// {
//     Console.WriteLine(n1 + " > " + n2);
// }
// else
// {
//     Console.WriteLine(n1 + " < " + n2);
// }

// 11. Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
int num = new Random().Next(100,1000);
int n1 = num / 10;
int n2 = num % 10;
int result = n1 - n1 % 10 + n2;
Console.WriteLine(num);
Console.WriteLine(result);

// 12. Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA % numB == 0) {
    Console.WriteLine(numA + " кратно " + numB);
}
else 
{
    Console.WriteLine(numA + " не кратно " + numB + " остаток от деления " + numA % numB);
}

// 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

Console.WriteLine("Введите число для проверки");
int numZ = Convert.ToInt32(Console.ReadLine());

if (numZ % 7 == 0 && numZ % 23 == 0)
{
    Console.WriteLine("Yes!");
}
else 
{
    Console.WriteLine("No");
}



// 16. Напишите программу, которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число X");
int numX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число Y");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX * numX == numY || numY * numY == numX) 
{
  Console.WriteLine("Yes!");
}
else 
{
    Console.WriteLine("No");
}