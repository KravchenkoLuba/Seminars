 //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
 //или же указание, что такого элемента нет.
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

void FindElement(int i, int j, int[,]array)
{
    if(i<array.GetLength(0) && j<array.GetLength(1))
         Console.WriteLine(array[i,j]);
    else Console.WriteLine( "There is no such element");    
}

Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ourArray =  CreateArray(m,n,1,25);
ShowArray(ourArray);
Console.Write("Input i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Input j: ");
int j = Convert.ToInt32(Console.ReadLine());
FindElement(i,j,ourArray);





