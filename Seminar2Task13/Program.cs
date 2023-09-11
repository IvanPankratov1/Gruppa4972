// Задача №13 Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

string line = Console.ReadLine() ?? "0";
char[] digits = line.ToCharArray();
if (digits.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine(digits[2]);
