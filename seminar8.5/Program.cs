// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника
// Console.WriteLine("Сколько строк треугольника Паскаля вы хотите увидеть?");
// int numN = Convert.ToInt32(Console.ReadLine());
// int [,] trianglePascal = new int [numN,numN];
Console.WriteLine("Сколько строк треугольника Паскаля вы хотите увидеть?");
int numN = Convert.ToInt32(Console.ReadLine());

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

void CreatePascalMatrix ()
{
   
    int [,] trianglePascal = new int [rows,cols];

    for (int i = 0; i < numN; i+=1 )
    {
        for (int j = 0; j < numN / 2 + 1; j+=1)
        {
            trianglePascal[i, j] = 1;
        }
    }

    PrintArr(trianglePascal);
}

CreatePascalMatrix();


