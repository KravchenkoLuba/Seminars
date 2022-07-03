//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumDigits(int num)
{
    int sum = 0;
    while(num > 0)
    {
        sum = sum + num%10;
        num = num/10;  
    }

    return sum;
}

Console.WriteLine("Input number ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of digits is "+ SumDigits(num1));




