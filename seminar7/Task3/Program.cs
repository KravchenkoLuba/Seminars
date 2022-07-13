 //Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце
int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int [,] newArray = new int[m,n];

    for(int i = 0; i<m; i++)
        for(int j = 0; j<n; j++)
            newArray[i,j] = new Random().Next(minValue,maxValue + 1);
    return newArray;        
}

void ShowArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }   
        
}

double FindMean(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
{
        double mean = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
             mean += array[i, j];
        }
    mean = mean/array.GetLength(0);
    return mean;
}
}
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ourArray =  CreateArray(m,n,1,25);
ShowArray(ourArray);
double mean = Convert.ToDouble(Console.WriteLine(FindMean(ourArray)));