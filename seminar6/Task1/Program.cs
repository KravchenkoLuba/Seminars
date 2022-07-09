 //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int NumberOfR(int m)
{
    int count = 0;
    int i = 1;
    for (i=1; i<=m; i++)
    {
        Console.WriteLine("Input a ");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a > 0) count++;
    }
    return count;
}
Console.WriteLine("Input number ");
int m = Convert.ToInt32(Console.ReadLine());

int count = NumberOfR(m);
Console.WriteLine("Numbers greater than zero are " + count);
