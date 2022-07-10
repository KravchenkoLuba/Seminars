 //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 //значения b1, k1, b2 и k2 задаются пользователем.

 void FindIntersectionPoint(int b1, int k1, int b2, int k2)
 {
    int x = (b2-b1)/(k1-k2);
    int y = x*k1 + b1;
    Console.WriteLine($"Intersection point is ({x};{y})");
 }
 
Console.WriteLine("Input b1 ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k1 ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input b2 ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input k2 ");
int k2 = Convert.ToInt32(Console.ReadLine());

FindIntersectionPoint(b1, k1, b2, k2);