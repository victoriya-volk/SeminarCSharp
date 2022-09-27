// Задача 53: Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите количество строк:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int numN = Convert.ToInt32(Console.ReadLine());

int [,] NewArray (int m, int n)
{
    int [,] newArr = new int [m, n];
    for (int i =0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            newArr[i , j] = new Random().Next( 100, 1000);
        }
    }
    return newArr;
}

void PrintArr (int [,] arr) 
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]} ");
        } 
        Console.WriteLine();
    }
    
}
int [,] myArr =  NewArray(numM, numN);
PrintArr(myArr);
Console.WriteLine();

void ChangeFirstAndLastRow (int [,] array) 
{
    int help = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        help = array[0, i];
        array[0 ,i] = array[array.GetLength(0) -1 , i];
        array[array.GetLength(0) -1 , i] = help;
    }
}

ChangeFirstAndLastRow(myArr);
Console.WriteLine("Changing matrix");
PrintArr(myArr);

