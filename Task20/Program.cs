﻿double Distance(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    double c = Math.Sqrt(x * x + y * y);
    return c;
}

Console.WriteLine("Введите координату первой точки по x:");
int num1X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату первой точки по y:");
int num1Y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по x:");
int num2X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату второй точки по y:");
int num2Y = Convert.ToInt32(Console.ReadLine());

double result = Distance(num1X, num1Y, num2X, num2Y);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);

Console.WriteLine($"Расстояние между точками равно {resRound}");

