// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размерность rows массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность columns массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];

void CreateMatrixInt(int rows, int columns)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < rows; i++)
    {
        Console.Write("|");
        for (j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(1, 9);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine("|");
    }
}

void ArithmeticMean(int rows, int columns)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < rows; j++)
    {
        double sum = 0;
        for (i = 0; i < columns; i++)
        {
            sum += matrix[i, j];
        }
        Console.Write($"{sum / (i):F1}; ");
    }
}
CreateMatrixInt(rows, columns);
ArithmeticMean(rows, columns);


