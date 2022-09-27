// Задача 57: Составить частотный словарь элементов двумерного массива.
//  Частотный словарь содержит информацию о том, сколько раз встречается 
//  элемент входных данных.

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
            newArr[i , j] = new Random().Next( 0, 10);
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

int [] MatrixMinMax (int [,] array)
{
    int minNum = array[0, 0];
    int maxNum = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j]< minNum)
            {
                minNum = array[i, j];
            } 
            else if (array[i,j] > maxNum)
            {
                maxNum = array[i,j];
            }
        }
    }
    int [] minMax = {minNum, maxNum};
    return minMax;
}
int [,] myArr =  NewArray(numM, numN);
PrintArr(myArr);
Console.WriteLine();
int [] resultMinMax = MatrixMinMax(myArr);

void DictionaryMatrix (int [,] array, int[] minMaxArray)
{
    for (int i = minMaxArray[0]; i <= minMaxArray[1]; i++)
    {
        int count = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (i == array[j, k]) count+= 1;
            }
        }
        if (count > 0)
        {
            Console.WriteLine($"Число {i} встречается {count} раз(а).");
        }
    }
}

DictionaryMatrix(myArr, resultMinMax);



