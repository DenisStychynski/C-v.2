// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое целое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int num2 = Convert.ToInt32(Console.ReadLine());

int deg = 1;
if (num2 < 1)

    Console.WriteLine("не натуральное число ");

else
{
    while (num1 != 0)
    {
        deg = deg* num1;
        num2 = num2 - 1;
    }
    Console.WriteLine($"Данное число в степени = {deg} ");
}



