// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
int NumDigits(int num)
{
    int count = 0;
    while (num > 0) 
    {
        count ++;
        num = num/10;
    }
    return count;
}
int n = ReadData("Введите число");
PrintResult ("количество цифр в числе = " + NumDigits(n));
