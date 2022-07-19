//Заполните спирально массив 4 на 4.
int[,] FillArraySpiral(int n)
{
    int[,] Array = new int[n,n];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= Array.GetLength(0) * Array.GetLength(1))
    {
        Array[i, j] = temp;
        temp++;
            if (i <= j + 1 && i + j < Array.GetLength(1) - 1)
                j++;
            else if (i < j && i + j >= Array.GetLength(0) - 1)
                i++;
            else if (i >= j && i + j > Array.GetLength(1) - 1)
                j--;
            else
                i--;
    }
    return Array;
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

Console.Write("Input n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] ourArray = FillArraySpiral(n);
ShowArray(ourArray);