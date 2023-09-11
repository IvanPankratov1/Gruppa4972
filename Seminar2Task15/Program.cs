// Задача №15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

void Variant1()

{
    Console.WriteLine("Введите число");
    int day = int.Parse(Console.ReadLine() ?? "0");

    string[] dayOfWeek = new string[7];

    dayOfWeek[0] = "Понедельник";
    dayOfWeek[1] = "Вторник";
    dayOfWeek[2] = "Среда";
    dayOfWeek[3] = "Четверг";
    dayOfWeek[4] = "Пятница";
    dayOfWeek[5] = "Суббота";
    dayOfWeek[6] = "Воскресенье";
    if (day > 4)
    {
        Console.WriteLine(dayOfWeek[day - 1]);
        Console.Write("Выходной");
    }
    else
    {
        Console.WriteLine(dayOfWeek[day - 1]);
    }
}
void Variant2()
{
Dictionary <int, string> dict = new Dictionary<int, string>();
dict.Add(1, "Понедельник");
dict.Add(2, "Вторник");
dict.Add(3, "Среда");
dict.Add(4, "Четверг");
dict.Add(5, "Пятница");
dict.Add(6, "Суббота");
dict.Add(7, "Воскресение");
// Другой способ ввести Dictionary
// var days = new Dictionary <int, string>();

// days [1] ="понедельник";
// days [2] ="вторник";
// days [3] ="среда";
// days [4] ="четверг";
// days [5] ="пятница";
// days [6] ="суббота";
// days [7] ="воскресение";

// Другой способ ввести Dictionary
// {
//   {1, "Понедельник"},
//   {2, "Вторник"},
//   {3, "Среда"},
//   {4, "Четверг"},
//   {5, "Пятница"},
//   {6, "Суббота"},
//   {7, "Воскресение"},
// };

int i = Convert.ToInt32(Console.ReadLine());
if (i > 5)
{
    Console.Write (dict[i] + " Выходной");
    //Console.Write (dict[i]);
    //Console.Write (" Выходной");
        
}
else
{
Console.WriteLine (dict[i]);
}
// Выводит в столбец все дни недели
// for (int i = 0; i < 8; i++)
// {
//    string value = dict.GetValueOrDefault(i);
//    Console.WriteLine(value);
// }
}

// Variant1();
Variant2();