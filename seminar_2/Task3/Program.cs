void Weekday(int number)
{
    if(number < 6) Console.WriteLine("No");
    else Console.WriteLine("Yes");
}

Console.WriteLine("Input number from 1 to 7 ");
int number = Convert.ToInt32(Console.ReadLine());
Weekday(number);