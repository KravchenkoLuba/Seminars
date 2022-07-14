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

double[] FindMean(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double mean = Math.Round((sum/array.GetLength(0)),2);
        result[j] = mean;
    }
    return result;
}

void ShowOneArray(double[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        Console.WriteLine($"Arithmetic mean column  {i} = {array[i]}");
    }
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ourArray =  CreateArray(m,n,1,25);
ShowArray(ourArray);
double[] ArrayMean = FindMean(ourArray);
ShowOneArray(ArrayMean);