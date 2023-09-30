// #69 Напишите прграмму, которая будет принимать 2 числа А и В
// возыедите А в степень В с помощью рекурсии


// // второй вариант:
// // Вывод сообщения и запись введённых данных
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine()??",";
//     int number = Convert.ToInt32(value);

//     return number;
// }
// // Считает сумму
// int Exponentiation(int number, int stepen)
// {
//     return stepen == 2 
//     ? number * number
//     : stepen <= 1 
//         ? number 
//         : stepen % 2 == 0 
//             ? Exponentiation(number, stepen / 2) * Exponentiation(number, stepen / 2)
//             : Exponentiation(number, stepen / 2 + 1) * Exponentiation(number, stepen / 2);
// }

// int number = Prompt("Введите число: ");
// int stepen = Prompt("Введите степень: ");

// Console.WriteLine($"Число {number} в степени {stepen} = {Exponentiation(number, stepen)}");

int ReadData(string msg) // вводим данные
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long DigitPower(int n, int p)
{
    if(p == 1) return n;
    if(p == 2) return n*n;
    if(p > 0){
    return DigitPower(n, p/2)*DigitPower(n, p - p/2);
    } else return 1;
}
int n = ReadData("Введите основание");
int m = ReadData("Введите степень");
Console.WriteLine($"Возведение в степень { DigitPower(n,m)}");