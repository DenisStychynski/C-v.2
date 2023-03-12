Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = number1 % number2;
if (number3 == 0)
{
    Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine("Не кратное");
}
Console.Write(number3);
/////////////////////////////////////////

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int result = RemaiderDivision(number1,number2);

if (result ==0 )
 Console.WriteLine("Кратное");
else
 Console.WriteLine("Не кратное");

int RemaiderDivision(int nim1, int num2)
{
    return nim1 % num2;
}