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
// Variant2();


// ВАРИАНТ 3 
// решение задачи без использования массива

// Приглашение в консоли ввести число
Console.WriteLine("Введите положительное число");

// Создаем переменную num И с консоли вводим ее значение.  
// При этом сразу проверяем на null и конвертируем  в int
int num = int.Parse(Console.ReadLine() ?? "0");

// вычисляем разрядность введенного числа c помощью десятичного логарифма
double digit = Math.Log10(num);
// Конвертирую double -> int и отбрасываю дробную часть
digit = (int)digit;

// проверяем введенное число,  оно должно быть 3х значное или больше
if (digit > 1)
{
    // устанавливаем счетчик
    int count = 1;
    // объявляем переменную
    int res = num;
    while (count < digit - 1)
    {
        // отбрасываем число до 3 знаков
        res = res/10;
        count ++;
    }
    // Выводим последнюю цифру числа
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.Write(", равняется: ");
    Console.WriteLine(res%10);
}

else
{
    // Выводим результат если введено двузначное или однозначное число
    Console.Write("Третья цифра в числе: ");
    Console.Write(num);
    Console.WriteLine(", отсутствует!");
}
