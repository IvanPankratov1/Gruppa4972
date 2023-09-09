// Задача 8: Напишите программу, которая на вход принимает число (N),
//  а на выходе показывает все чётные числа от 1 до N.
// Console.WriteLine("Введите число:"); // Текст в консоли 
// int num = Convert.ToInt32(Console.ReadLine()??"0"); // Вводим число и конвертируем его
// int count = 0; // Счетчик
// if (num % 2 == 0) // Проверка на четность
// {
//     while (count < num) // Цикл, пока меньше num
//     {
//         count = count + 2; // Сразу по 2 , по четным
//         Console.WriteLine(count); // Вывод ответа
//     }
// }
// else
// {
//         num = num - 1; // При нечетном числе будет считать до него, иначе выведет число и после него 
//         while (count < num) // Цикл, пока меньше num
//     {
//         count = count + 2; // Сразу по 2 , по четным
//         Console.WriteLine(count); // Вывод ответа
//     }
// }

Console.Write("Введите число: "); // Создаем строку ввода
string? inputlineN = Console.ReadLine(); // Инициализируем сканер
int startNumber = 2; // Переменна, с кот начинается отчет

if (inputlineN != null) // Проверяем, что строка не пустая
{
int inputnumberN = int.Parse(inputlineN); // Парсим строку в инт
while (startNumber <= inputnumberN - 2) // Условие завершения цикла
{
Console.Write(startNumber + ", "); // Если число делится - выводим в консоль
startNumber = startNumber + 2; // прибавляем единицу к числу
}

if (startNumber % 2 == 0)
{
    Console.WriteLine(startNumber);
}
}