﻿// Задача 2: Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Первое число:"); // Выводим текст в консоль
int numA = Convert.ToInt32 (Console.ReadLine()??"0"); // Вводим число и конвертируем его
Console.WriteLine("Второе число:"); // Выводим текст в консоль
int numB = int.Parse(Console.ReadLine()??"0"); // Вводим число и конвертируем его
if (numA > numB) // Сравнение
{
    Console.WriteLine("Больше:" + numA  + " Меньше:" + numB); // Если все норм, то вывод такой)))
}
else
{   
    Console.WriteLine("Больше:" + numB + " Меньше:" + numA); // Если нет, то вывод такой))
}