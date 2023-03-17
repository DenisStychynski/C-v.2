﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма  цифр в числе {number}: {sumNumbers}");

int SumNumbers (int num)
{
   int sum = 0;
    while (num != 0)
    {
        sum = sumNumbers + num % 10;
       
        num /=10;
    }
    return sum;
}