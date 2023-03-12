int RemoveSecondDigit (int num)
{
     int firstDigit = num / 100;
     int thirDigit = num % 10;
     int result = firstDigit * 10 + thirDigit;
    
     return result;
}

int number = new Random().Next(100, 1000);
int removeSecondDigit = RemoveSecondDigit (number); 
 Console.WriteLine($"Случайное число из отрезка 100 - 999 -> {number}");
 Console.WriteLine($"Числа -> {removeSecondDigit} ");