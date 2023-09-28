// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// // Заполнение массива рандомными числами от 1 до 9
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

// //  Функция вывода массива в терминал
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

// // Функция ввода 
// int ReadInt(string message)
// // // {
// // //     Console.Write(message);
// // //     return Convert.ToInt32(Console.ReadLine());
// // // }




using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write( matrix[i,j] + "\t");
            }
        }


    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
        int[,] arr = new int[n, m];
        int z = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                arr[i, j] = 1 + z;
                z += k;
                
            }
        }
        return arr;

    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      // Введите свое решение ниже
        if (rowPosition > matrix.GetLength(0) || columnPosition > matrix.GetLength(1))
        {
            return new int[0];
        }
        else
        {
            int[] result = new int[2];
            result[0] = matrix[rowPosition - 1, columnPosition - 1];
            return result;
        }

    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
      // Введите свое решение ниже
        if (results.Length == 0)
        {
            Console.WriteLine();
            Console.WriteLine("There is no such index");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }

        
    }

    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}


// Console.WriteLine("введите номер строки");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите номер столбца");
// int m = Convert.ToInt32(Console.ReadLine());

// int [,] numbers = new int [5,5];

// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
// }
// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }



