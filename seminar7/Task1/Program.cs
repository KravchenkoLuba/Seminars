// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateDoubleArray(int m, int n)
{
    double [,] newArray = new double[m,n];

    for(int i = 0; i<m; i++)
        for(int j = 0; j<n; j++)
            newArray[i,j] = Math.Round((new Random().Next(0,100) + new Random().NextDouble()),1);
    return newArray;        
}

void ShowDoubleArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }   
        
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = CreateDoubleArray(m, n);
ShowDoubleArray(myArray);

