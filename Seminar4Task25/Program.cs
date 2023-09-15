// №25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16 

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
long MyPow(int a, int b)
{
    long res = 1;
    while (b > 0)
    {
        res =res*a;
        b = b - 1;
    }
    return res;
}
int a = ReadData("Введите число: ");
int b = ReadData("Введите степень: ");
long res = MyPow(a, b);
PrintResult("Возведение числа А в натуральную степень числа В = " + res);
