﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число:"); // Выводим текст в консоль
int num = Convert.ToInt32(Console.ReadLine()??"0"); // Вводим число и конвертируем его
if (num % 2 == 0) // Проверка на четность
Console.WriteLine("Число четное"); // Ответ
else 
Console.WriteLine("Число нечетное"); // Ответ
// Console.WriteLine(num % 2 == 0 ? "Число четное" : "Число нечетное");