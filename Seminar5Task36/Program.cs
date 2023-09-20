// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

//Заполняем одномерный массив
int[] GenArray(int num, int lowBorder, int highBorder)
{
int[] array = new int[num];
  
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder+1);
    }

    return array;
}

// Печатаем массив
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
        
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Находим сумму элементов на нечетных похициях
int SumNegPos(int[] arr)
{
    int Sum = 0;
    for(int i =1;i<arr.Length;i=i+2)
    {
        Sum=Sum+arr[i];
    }
    return Sum;
}

// Тело программы
int[] array = GenArray(12,-9,9);
PrintArray(array);
int sum = SumNegPos(array);
Console.WriteLine("Cумма элементов, стоящих на нечётных позициях = "+sum);
