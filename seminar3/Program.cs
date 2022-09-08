// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится 
// эта точка.

Console.WriteLine("Введите координату X:");
int numX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX > 0 && numY > 0) 
{
    Console.WriteLine("Точка находится в 1 четверти");
}
else if (numX < 0 && numY > 0) 
{
    Console.WriteLine("Точка находится в 2 четверти");
}
else if (numX < 0 && numY < 0) 
{
    Console.WriteLine("Точка находится в 3 четверти");
}
else if (numX > 0 && numY < 0) 
{
    Console.WriteLine("Точка находится в 4 четверти");
}
else 
{
    Console.WriteLine("Координаты не должны быть равны 0!");
}

// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четврети:");
int numberPart = Convert.ToInt32(Console.ReadLine());

if (numberPart == 1) {
    Console.WriteLine("X > 0 && Y > 0");
}
else if (numberPart == 2) {
    Console.WriteLine("X < 0 && Y > 0");
}
else if (numberPart == 3) {
    Console.WriteLine("X < 0 && Y < 0");
}
else if (numberPart == 4) {
    Console.WriteLine("X > 0 && Y < 0");
}
else 
{
    Console.WriteLine("У нас всего 4 четверти!");
}

// Задача 21: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X точки А:");
int dotAX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А:");
int dotAY = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату X точки B:");
int dotBX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B:");
int dotBY = Convert.ToInt32(Console.ReadLine());

double distAB = Math.Sqrt(Math.Pow(dotBX - dotAX, 2) + Math.Pow(dotBY - dotAY, 2));
Console.WriteLine(Math.Round(distAB, 2));

// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

 Console.WriteLine("Введите число:");
int numZ = Convert.ToInt32(Console.ReadLine());

for ( int i = 1; i <= numZ; i++)
{
    Console.WriteLine($"{i*i}");
}