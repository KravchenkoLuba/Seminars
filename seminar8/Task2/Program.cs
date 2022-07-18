// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
    Console.WriteLine();    
}

int FindMinSumRow(int[,] array)
{
    int minRowSum = int.MaxValue, iMinRow = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            rowSum+= array[i,j];
        }
        if(rowSum < minRowSum)
        {
            minRowSum = rowSum;
            iMinRow = i;
        }
    }
    return iMinRow;
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input minValue: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maxValue: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int [,] my2dArray = CreateArray(m, n, minValue, maxValue);
ShowArray(my2dArray);
int iMinRow = FindMinSumRow(my2dArray);
Console.WriteLine("Minimum Summ of elements row is " + iMinRow);