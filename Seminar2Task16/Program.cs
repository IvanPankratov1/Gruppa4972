﻿// Задача №16
// Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.
void Variant1()

{
Console.WriteLine("Введите 1-е число: ");
int firstNum = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите 2-е число: ");
int secondNum = int.Parse(Console.ReadLine() ?? "0");

bool test1 = (firstNum == secondNum * secondNum);
bool test2 = (secondNum == firstNum * firstNum);

if (test1)
{
    Console.WriteLine("Первое число квадрат второго");
}
if (test2)
{
    Console.WriteLine("Второе число квадрат первого");
}
if (!(test1 || test2))
{
    Console.WriteLine("Число 1 не квадрат 2-го и число 2 не квадрат 1-го");
}
}

Variant1();

// int a = int.Parse(Console.ReadLine()??"0");
// int b = int.Parse(Console.ReadLine()??"0");

// bool test1 = a == b*b;
// bool test2 = b == a*a;

// if(test1){
//     Console.WriteLine("Первое квадрат второго");
// }else if(test2){
//     Console.WriteLine("Второе квадрат первого");
// }else{
//     Console.WriteLine("Одно не является квадратом другого");
// }