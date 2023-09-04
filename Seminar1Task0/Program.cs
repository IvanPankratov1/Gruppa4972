// Задача №0
// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите число: ");

string? inputNum = Console.ReadLine(); //??"0";
// Проверяем, чтобы данные были не пустыми
if (inputNum != null)
{
    
    int num = int.Parse(inputNum);

    int resalt = num*num;

    Console.WriteLine(resalt);
}

// Console.WriteLine("Квадрат числа:"+(int)Math.Pow(int.Parse(inputNum), 2)); решение в 1у строчку