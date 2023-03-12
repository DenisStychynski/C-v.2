int ShowSecondDigit (int num)
{
     
     int result = -1;
     if (num >=100)
     {
        while (num > 999)
        {
            num = num /10; 
        }
        result = num % 10;
     } 
    
     return result;
}

int number = new Random().Next();
int showSecondDigit = ShowSecondDigit (number); 
if (number < 0 ) number = -number;
Console.WriteLine($"Случайное число  -> {number}");

if(ShowSecondDigit(number) == -1)
Console.WriteLine ("Третьей цифры нет");

else
Console.WriteLine (showSecondDigit);


