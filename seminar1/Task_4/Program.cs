int N;
int current;

Console.Write("Input number  ");
N = Convert.ToInt32(Console.ReadLine());

current = 1;

if(N > 0)

{
    while(current <= N)
    {
        if(current % 2 == 0)
        {
            Console.Write(current + " ");
        }
        current++;
    }
}
else 
{
    while(current >= N)
    {
        if(current % 2 == 0)
        {
            Console.Write(current + " ");
        }
        current--;
    }
}
