void Palindrome(int num)
{
    int res1 = num /10000;
    int res2 = num %10;
    int res3 = num %10000/1000;
    int res4 = num %100/10;
    if(res1==res2 && res3==res4)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}
Console.Write("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number);
