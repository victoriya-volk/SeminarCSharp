// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
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
            newArr[i , j] = new Random().Next( -1, 10);
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

int [] MatrixMin (int [,] array)
{
    int minNum = 0;
    int [] minNumPosition = new int [2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]< minNum)
            {
                minNum = array[i, j];
                minNumPosition[0] = i;
                minNumPosition[1] = j;
            } 
        }
    }
    return minNumPosition;
}

int [,] DeletedMinNumRowCol (int [,] array, int X, int Y)
{
    int [,] newArray = new int [array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++ )
    {
        if (i != X)
        {
            int coordX = i;
            if (i > X) coordX = i -1;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != Y)
                {
                    int coordY = j;   
                    if (j > Y) coordY = j -1;
                    newArray[coordX, coordY] = array[i, j];
                }
            }
        }
    }
    return newArray;
}
int [,] myArr =  NewArray(numM, numN);
PrintArr(myArr);
Console.WriteLine();
int [] minPos = MatrixMin(myArr);
int [,] deletedResult = DeletedMinNumRowCol(myArr, minPos[0], minPos[1]);
PrintArr(deletedResult);
