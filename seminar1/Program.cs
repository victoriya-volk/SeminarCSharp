
// Console.WriteLine("Введите число");
// int usernumber = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(usernumber * usernumber);

// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет
// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());
if (numA == numB * numB) 
{
   Console.WriteLine("Да!)"); 
}
else
{
    Console.WriteLine("Нет("); 
}

Console.WriteLine("Введите номер: ");
string numberDay = Console.ReadLine();
 
switch (numberDay)
{   
    case "0":
        Console.WriteLine("Неделя начинается с 1-го дня)");
        break;
    case "1":
        Console.WriteLine("Понедельник");
        break;
    case "2":
        Console.WriteLine("Вторник");
        break;
    case "3":
        Console.WriteLine("Среда");
        break;
    case "4":
        Console.WriteLine("Четверг");
        break;
    case "5":
        Console.WriteLine("Пятница");
        break;
    case "6":
        Console.WriteLine("Суббота");
        break;
    case "7":
        Console.WriteLine("Воскресенье");
        break;
    default:
    Console.WriteLine("В неделе всего 7 дней)");
    break;
}