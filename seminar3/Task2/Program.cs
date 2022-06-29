double FindDistance(double x1, double y1, double z1,double x2, double y2, double z2)
{
    double l1 = x2-x1;
    double l2 = y2-y1;
    double l3 = z2-z1;
    double dis =  Math .Sqrt(l1*l1 + l2*l2 + l3*l3);
    
    return dis;

}

Console.Write("Input x1 coordinate: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y1 coordinate: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z1 coordinate: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input x2 coordinate: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input y2 coordinate: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input z2 coordinate: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(FindDistance(x1, y1, z1, x2, y2, z2));
