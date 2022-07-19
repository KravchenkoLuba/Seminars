// Задайте значение N. Напишите программу, которая найдет факториал числа N рекурсивным методом.
int Factorial(int n)
{
    if(n>0)
    {
        return n*Factorial(n-1);
    } 
    else return 1;
}

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(n));