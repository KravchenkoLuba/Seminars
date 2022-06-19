int n1, n2, n3;

Console.Write("Введите первое число");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число");
n2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число");
n3 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
{
    if(n1 >n3)
    {
        Console.WriteLine($"{n1}");
    }
    else
    {
        Console.WriteLine($"{n3}");
    }
}
else
{
    if(n2 > n3)
    {
        Console.WriteLine($"{n2}");
    }
    else
    {
         Console.WriteLine($"{n3}");
    }
}