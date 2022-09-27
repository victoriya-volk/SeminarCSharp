// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.
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

void ChangeRowsAndColumns(int [,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int help = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                help = array[i, j];
                array[i,j] = array[j,i];
                array[j,i] = help;
            }
        }
    }
    else 
    {
        Console.WriteLine("Этот массив не подходит");
    }
}

ChangeRowsAndColumns(myArr);
Console.WriteLine("Changing matrix:");
PrintArr(myArr);