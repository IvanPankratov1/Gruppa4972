// Задача 4: Напишите программу, которая принимает на вход три числа
//  и выдаёт максимальное из этих чисел.
Console.WriteLine("Первое число:"); // Выводим текст в консоль
int first = Convert.ToInt32(Console.ReadLine()??"0"); // Вводим число и конвертируем его
Console.WriteLine("Второе число:"); // Выводим текст в консоль
int second = Convert.ToInt32(Console.ReadLine()??"0"); // Вводим число и конвертируем его
Console.WriteLine("Третье число:"); // Выводим текст в консоль
int third = Convert.ToInt32(Console.ReadLine()??"0"); // Вводим число и конвертируем его
if (first > second) // Сравниваем первое и второе
{
    if (first > third) // Сравниваем первое и третье
        Console.WriteLine("Max:" + first); // Если все норм выводим первое
        else
        Console.WriteLine("Max:" + third); // Если нет, то выводим третье
}
else    
{
    if (second > third) // Сравниваем второе и третье
        Console.WriteLine("Max: " + second); //Если все норм, выводим второе
    else 
        Console.WriteLine("Max:" + third); // Если нет, то выводим третье
}