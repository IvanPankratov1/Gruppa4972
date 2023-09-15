// №29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int[] GenArr(int Len)
{
    int[] arr = new int[Len];
    Random rnd = new Random();
    for (int i = 0; i < Len; i++)
    {
        arr[i] = rnd.Next(1, 8);
    }
    return arr;
}
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
        
    }
    Console.Write(arr[arr.Length - 1] + "]");
}
int len = ReadData("Введите длину массива: ");
int[] arr = GenArr(len);
PrintArr(arr);