void ShowSecondDigit(int number);
{
    Console.WriteLine("Input three figures ");
    int number = Convert.ToInt32(Console.ReadLine());
    int digit = (number%100)/10;
    Console.WriteLine("Second number is" + digit);
}
