// Задание 1 - написать программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите первое число");
Console.WriteLine("Введите второе число");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;

if(number1 > number2) max = number1
{
    Console.WriteLine("max = " + number1);
    Console.WriteLine("min = " + number2);
}
else
{
    Console.WriteLine("max = " + number2);
    Console.WriteLine("min = " + number1);
}