// Задача 23: Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

using System;

public class Answer
{
  static void ShowCube(int N)
  {
    // Введите свое решение ниже
    Console.WriteLine("Введите число: ");
    int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine();
    for (int i = 1; i <= number; i++)
    {
      Console.WriteLine(Math.Pow(i, 3));
    }

  }

  // Не удаляйте и не меняйте метод Main! 
  static public void Main(string[] args)
  {
    int N;

    if (args.Length >= 1)
    {
      N = int.Parse(args[0]);
    }
    else
    {
      // Здесь вы можете поменять значения для отправки кода на Выполнение
      N = 6;
    }

    // Не удаляйте строки ниже
    ShowCube(N);
  }
}
// Решние для ГБ
// for (int i = 1; i <= N; i++)
//     {
//       Console.WriteLine(Math.Pow(i, 3));
//     }