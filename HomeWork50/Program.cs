// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет



Console.Write("Введите размерность rows массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность columns массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
Console.Write("Введите позицию строки: ");
int rowsNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int columnsNum = Convert.ToInt32(Console.ReadLine());
void CreateMatrixRndInt(int rows, int columns)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < rows; i++)
    {
        Console.Write("|");
        for (j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 100);
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
CreateMatrixRndInt(rows, columns);
if (rowsNum < 1 || columnsNum < 1)
    Console.Write("Позиции строк не могут быть отрицательными");
else if (rowsNum <= rows + 1 && columnsNum <= columns + 1)
    Console.Write($"Значение элемента равно {matrix[rowsNum - 1, columnsNum - 1]}");
else Console.Write("Такого элемента нет в массиве");

