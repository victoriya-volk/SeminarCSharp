// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

double NumberDegree (int n, int m)
{
    if (m <= 1) return n;
    else return NumberDegree(n, m- 1)* n;
}
Console.WriteLine(NumberDegree(3,5));