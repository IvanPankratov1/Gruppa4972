﻿// Задача №11
// Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.

int number = new  Random().Next(100, 1000);
Console.WriteLine(number);

int firstDigit = number/100;
int lastDigit = number%10;
number = firstDigit*10 + lastDigit;

Console.WriteLine(number);
