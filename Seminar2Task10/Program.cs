// №10 Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.

    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(100, 1000);
    Console.WriteLine(number);
    int secondDigit = (number / 10) % 10;
    Console.WriteLine(secondDigit);



