// №25 Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵) 2, 4 -> 16 

// Вводим данные
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// // Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Возведение в степень
// long MyPow(int a, int b)
// {
//     long res = 1;
//     while (b > 0)
//     {
//         res =res*a;
//         b = b - 1;
//     }
//     return res;
// }
// int a = ReadData("Введите число: ");
// int b = ReadData("Введите степень: ");
// long res = MyPow(a, b);
// PrintResult("Возведение числа А в натуральную степень числа В = " + res);



// Пример одногрупника 

// //Вводим данные
// string ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     string data = Console.ReadLine();
//     return data;
// }

// //Функция сложения
// double plus(int a, int b)
// {
//     double result = a + b;
//     return result;
// }

// //Функция вычитания
// double minus(int a, int b)
// {
//     double result = a - b;
//     return result;
// }

// //Функция умножения
// double multiplication(int a, int b)
// {
//     double result = a * b;
//     return result;
// }

// //Функция деления
// double division(int a, int b)
// {
//     double result = a / b;
//     return result;
// }

// //Функция возведения в степень
// double degree(int a, int b)
// {
//     double result = Math.Pow(a, b);
//     return result;
// }

// //Печатаем результат
// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int a = int.Parse(ReadData("Введите число А"));
// int b = int.Parse(ReadData("Введите число B"));
// string operand = ReadData("Введите операцию (+, -, *, /, ^)");

// //double result = getResult(a, b, operand);

// double result = 0;

// switch (operand)
// {
//     case "+": 
//     result = plus(a, b);
//     break;
//     case "-": 
//     result = minus(a, b);
//     break;
//     case "*": 
//     result = multiplication(a, b);
//     break;
//     case "/": 
//     result = division(a, b);
//     break;
//     case "^": 
//     result = degree(a, b);
//     break;
//     default: Console.WriteLine("Что-то пошло не так");
//     break;
// }

// PrintResult("Результат операции = " + result);