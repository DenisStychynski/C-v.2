//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// -1, -7, 567, 89, 223-> 3


Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

void ArrayNumbers(int size)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}


int PositiveNumbers(int[] array)
{
    int i = 0;
    int sum = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
            sum = sum + 1;
        i = i + 1;
    }
    return sum;
}
ArrayNumbers(size);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.Write($"Чисел больше нуля: {PositiveNumbers(array)}");