double FindDistance(int x1, int y1, int z1,int x2, int y2, int z2)
{
    int l1 = x2-x1;
    int l2 = y2-y1;
    int l3 = z2-z1;
    double dis =  Math .Sqrt(l1^2 + l2^2 + l3^2);
    Console.WriteLine(dis);

}

Console.Write("Input number");
int N = Convert.ToInt32(Console.ReadLine());