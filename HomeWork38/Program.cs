// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2





double[] array = CreateArrayRndInt(5);

 double [] CreateArrayRndInt(int size)
{
    double[] arr = new double[size];
    Random  rnd = new  Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] =rnd.NextDouble();
        
    }
    return arr;
}

void PrintArray (double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr [i]:F2}, ");
        else Console.Write ($"{arr[i]:F2}");
    }
    Console.Write("]");
}


double Raz(double[] arr)
{
double min = arr[0];
double max = arr[0];
int i = 1;
while (i < arr.Length)
{
if (max<arr[i])
max = arr[i];
if (min>arr[i])
min = arr[i];
i = i + 1;
}
return max-min;
}

double raz = Raz(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"\nРазница между максимальным и минимальным элементов массива: {raz:F2}");



