// Задача №13 Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

void Variant1()
{
string line = Console.ReadLine() ?? "0";
char[] digits = line.ToCharArray();
if (digits.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
Console.WriteLine(digits[2]);
}
void Variant2()
{
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()??"0");
if (num > 9 && num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
if (num > 99 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine(lastDigit);
}
if(num > 999 && num < 10000)
{
    int lastDigit = (num /10) % 10;
    Console.WriteLine(lastDigit);
}
if(num > 9999 && num < 100000)
{
    int lastDigit = (num /100) % 10;
    Console.WriteLine(lastDigit);
}
if(num > 99999 && num < 1000000)
{
    int lastDigit = (num /1000) % 10;
    Console.WriteLine(lastDigit);
}
if(num > 999999 && num < 10000000)
{
    int lastDigit = (num /10000) % 10;
    Console.WriteLine(lastDigit);
}
if(num > 9999999 && num < 100000000)
{
    int lastDigit = (num /100000) % 10;
    Console.WriteLine(lastDigit);
}
if(num > 99999999 && num < 1000000000)
{
    int lastDigit = (num /1000000) % 10;
    Console.WriteLine(lastDigit);
}
if(num > 999999999 && num < 10000000000)
{
    int lastDigit = (num /10000000) % 10;
    Console.WriteLine(lastDigit);
}
}

// Variant1();
Variant2();