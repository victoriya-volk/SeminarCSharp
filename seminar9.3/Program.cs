// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int SumPartsNumber (int num)
{
    if (num / 10 == 0 ) return +num;
    else
    {
        return SumPartsNumber(num/10) + num % 10;
    }
}

Console.WriteLine(SumPartsNumber(453));