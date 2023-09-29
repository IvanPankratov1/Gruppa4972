// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

// int rows = ReadInt("Введите номер строки: ");
// int colums = ReadInt("Введите номер столбца: ");

// int rows = 3;
// int colums = 4;
// int[,] numbers = new int[rows, colums];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// double[] avgNumbers = new double[numbers.GetLength(1)];

// for (int i = 0; i < numbers.GetLength(1); i++)
// {
//     double result = 0.0;
//     for (int j = 0; j < numbers.GetLength(0); j++)
//     {
//         result += numbers[j, i];
//     }
//     avgNumbers[i] = result / numbers.GetLength(0);
// }
// PrintArray(avgNumbers);


// Заполнение массива рандомными вещественными числами
// void FillArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// //  Функция вывода двумерного массива в терминал
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// // Функция вывода массива в терминал 
// void PrintArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// // Функция ввода 
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

﻿using System;

public class Answer
{
    public static void PrintArray(int[,] matrix)
    {
        // Введите свое решение ниже
        int m = matrix.GetLength(0);
        int n = matrix.GetLength(1);

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        // Введите свое решение ниже
        int[,] matrix = new int[n, m];
        int value = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = value;
                value += k;
            }
        }
        return matrix;
    }

    static void PrintListAvr(double[] list)
    {
        // Введите свое решение ниже
        Console.WriteLine("The averages in columns are: ");

        foreach (double average in list)
        {
            Console.Write($"{average:F2}\t");
        }
        Console.WriteLine();
    }

    static double[] FindAverageInColumns(int[,] matrix)
    {
        // Введите свое решение ниже
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        double[] averages = new double[m];

        for (int j = 0; j < m; j++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, j];
            }
            averages[j] = (double)sum / n;
        }

        return averages;

    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args)
    {
        int n, m, k;

        if (args.Length >= 3)
        {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
        }
        else
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            n = 3;
            m = 4;
            k = 2;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}