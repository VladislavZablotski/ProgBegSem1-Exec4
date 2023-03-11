using System;

System.Console.WriteLine("Введите число 1:");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2:");
int number2 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3:");
int number3 =Convert.ToInt32(Console.ReadLine());

int Max = number1;

if (number2>=Max)
{
    Max = number2;
}
if (number3>=Max)
{
    Max = number3;
}
Console.Write("Максимальное число равно ");
Console.WriteLine(Max);