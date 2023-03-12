Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
    if (num1 >=1 && num1 <=5)
        Console.WriteLine("Нет это не выходной");
    else if (num1 >=6 && num1 <=7)
        Console.WriteLine("Да, это выходной"); 
    else 
        Console.WriteLine("В неделе 7 дней, введи день от 1 до 7" );
