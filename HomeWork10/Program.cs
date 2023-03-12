int ShowSecondDigit (int num)
{
     int secondDigit = num % 100;
     int result = secondDigit / 10;
    
     return result;
}

int number = new Random().Next(1, 1000);
int showSecondDigit = ShowSecondDigit (number); 
 Console.WriteLine($"Случайное число из отрезка 1 - 999 -> {number}");
 Console.WriteLine($"Числа -> {showSecondDigit} ");