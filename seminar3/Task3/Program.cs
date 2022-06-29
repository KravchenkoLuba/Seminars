void CubeNumber (int N)
{
    int num = 1;
    while (num<=N)
    {
        Console.Write(num*num*num + " " );
        num++;
    }
}
Console.Write("Input number ");
int N = Convert.ToInt32(Console.ReadLine());
CubeNumber (N);
