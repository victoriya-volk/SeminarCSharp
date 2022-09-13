// Задача 31: Задайте массив из 12 элементов, заполненный случайными 
// числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20

int [] myArr = new int [12];
for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] = new Random().Next( -9, 10);
    Console.Write($"{myArr[i]} ");
} 

int BeforeZeroSum(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
             sum += arr[i];
        }
    }

    return sum;
}

int AfterZeroSum(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
             sum += arr[i];
        }
    }

    return sum;
}

Console.WriteLine();
int a = BeforeZeroSum(myArr);
int b = AfterZeroSum(myArr);
Console.WriteLine(a);
Console.WriteLine(b);

// Задача 32: Напишите программу замена элементов массива: положительные 
// элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]
// элементы замените на соответствующие отрицательные, и наоборот.

for (int i = 0; i < myArr.Length; i++)
{
    myArr[i] *= -1;
    Console.Write($"{myArr[i]} ");
}

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

string SearchNumber (int num, int[] arr)
{
    string answer = "";
    for (int i = 0; i < arr.Length; i++ )
    {
        if (num == arr[i])
        {
            answer = "Yes";
            return answer;
        }
    }
    answer = "No!";
    return answer;
}

string test = SearchNumber(6, myArr);
Console.WriteLine(test);

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int [] newArr = new int [123];
for (int i = 0; i < newArr.Length; i++)
{
    newArr[i] = new Random().Next( 0, 151);
} 

int CountNumbers (int[] arr, int min, int max)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > min && arr[i] < max)
        {
            count += 1;
        }
    }
    return count;
}

int count = CountNumbers(newArr, 10, 99);
Console.WriteLine(count);

// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void SumOfPairs (int [] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Console.WriteLine(arr[i] * arr[arr.Length - 1 -i]);
    }
}

SumOfPairs(myArr);

// Необходимо найти  5 целых чисел (положительных), которые будут удовлетворять такому условию
// x^5 + y^5 + z^5 + q^5 = w^5 Т.е. сумма 4 чисел в пятой степени = 5 числу

