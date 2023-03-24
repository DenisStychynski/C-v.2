// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// // [-4, -6, 89, 6] -> 0

int[] array = CreateArrayRndInt(9, -10, 50);
PrintArray(array);
Console.WriteLine();
int sumOddNum = SumOddNum(array);
Console.WriteLine();
Console.Write($"Сумма элементов нечетных позиций: {sumOddNum}");

int [] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random  rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =rnd.Next(min,max + 1);
    }
    return arr;
}
void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr [i]}, ");
        else Console.Write ($"{arr[i]}");
    }
    Console.Write("]");
}
int SumOddNum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

