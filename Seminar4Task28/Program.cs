// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.

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

long FactorialNum(int num)
{
    long fact=1;

    for(int i=2; i<=num; i++)
    {
        fact*=i;
    }
    return fact;
}

int enterNum=ReadData("Введите число: ");
long result=FactorialNum(enterNum);

PrintResult($"Произведение чисел от 1 до {enterNum} = {result}");