// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());

int сompositionNumbers = СompositionNumbers(number);
Console.WriteLine($"Произведение чисел от единицы до {number} = {сompositionNumbers}");

int СompositionNumbers(int num)
{
    int com = 1;
    for (int i = 2; i <= num; i++)
    {
        checked
        {
            com = com * i;
        }
    }
    return com;

}