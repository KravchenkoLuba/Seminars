// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int [,] ArrangeStringFromSmaller(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++ )
    {
         for(int j=0; j<array.GetLength(1); j++)
         {
            for(int n=0; n<array.GetLength(1)-1; n++)
            {
                if(array[i,n]>array[i,n+1])
                {
                    int temp=array[i,n];
                    array[i,n]=array[i,n+1];
                    array[i,n+1]=temp;
                }
            }
         }
    }
    return array; 
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
ShowArray(ArrangeStringFromSmaller(my2dArray));
        
            
                
               
                     
                    
                       
                    
            
            
                
            
                

        
       


