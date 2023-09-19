// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99]. 

// // Заполняет массив случайными цифрами
// int[] RandomArray()
// {
//     int[] randNums = new int[123];
//     for (int i = 0; i < randNums.Length; i++)
//         randNums[i] = new Random().Next(0, 200);
//     return randNums;
// }
// // Считает кол-во чисел 
// int CountElements(int[] array)
// {
//     int count = 0;

//     for (int i = 0; i < array.Length; i++)
//         if (array[i] >= 10 && array[i] <= 99) count++;

//     return count;
// }
// // Выводит элементы массива в консоль
// void OutputArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//         Console.Write(array[i] + ", ");
//     Console.WriteLine(array[array.Length - 1] + "]");
// }

// int[] array = RandomArray();
// OutputArray(array);
// Console.WriteLine($"Количество элементов массива в отрезке [10, 99]: {CountElements(array)}");

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder)
{

    int[] array = new int[num];

    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

// Печатаем результат
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");

    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим количество элементов в заданном диапазоне
int CountElm(int[] arr, int x, int y)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= x && arr[i] <= y)
        {
            count++;
        }
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(123, 0, 100);
PrintArray(array);
int x = 10;
int y = 99;
int count = CountElm(array, x, y);
PrintResult($"{count} элементов в заданном диапазоне");



