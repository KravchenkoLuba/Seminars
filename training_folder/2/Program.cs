// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
int MaxNumber(int a, int b, int c)
{
    int res = 0;
    if(a>b && a>c) res=a;
    if(b>a && b>c) res=b;
    if(c>a && c>b) res=c;
    if(a==b && a>c) res=a;
    if(a==c && a>b) res=a;
    if(b==c && b>a) res=b;
    if(a==b && a==c) res=a;
    return res;
}

Console.WriteLine("Input number a ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number c ");
int c = Convert.ToInt32(Console.ReadLine());
int res = MaxNumber(a,b,c);
Console.WriteLine("Max number is " +  res);