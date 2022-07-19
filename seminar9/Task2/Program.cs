// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SummFromMToN(int m, int n)
{
    if(n>m)
    {
        return SummFromMToN(m, n-1) + n;
    }
    return m;
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SummFromMToN(m,n));