// №27 Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
// Сумма цифр в числе
int SumDigit(int num)
{
    int res = 0;
    while (num > 0)
    {
        res = res + num % 10;
        num = num / 10;
    }
    return res;
}
int num = ReadData("Введите число: ");
int res = SumDigit(num);
PrintResult("Сумма цифр в числе = " + res);
