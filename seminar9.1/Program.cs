// Задача 63: Задайте значение N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
int startNum = 1;
void PrintNatural (int n)
{
    if (startNum <= n)
    {
        Console.Write($"{startNum}");
        startNum++;
        PrintNatural(n);
    }
}

PrintNatural(5);
Console.WriteLine();
PrintNatural(15);