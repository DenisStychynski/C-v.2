// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); ++i)
        for (int j = 0; j < matrix2.GetLength(1); ++j)
            for (int k = 0; k < matrix2.GetLength(0); ++k)
                resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];

    return resultMatrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3}");
        }
        Console.Write("  |");
        Console.WriteLine();
    }
}


void MatrixInitialization( int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            matrix[i, j] = rnd.Next(-10, 10);


}


Console.WriteLine("Введите размер rows матрицы");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер columns матрицы");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[columns, rows];

MatrixInitialization( matrix1);
MatrixInitialization( matrix2);

Console.WriteLine("Матрица 1");
Console.WriteLine();
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Матрица 2");
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");
Console.WriteLine();
PrintMatrix(MatrixMultiplication(matrix1, matrix2));