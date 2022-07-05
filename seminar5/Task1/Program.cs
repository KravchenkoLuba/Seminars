//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
int[] CreateArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i<size; i++)
        array[i] = new Random().Next(100,1000);
        
    return array;
}

void ShowArray(int[] array)
 {
    for(int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

 }

int NumberOfEven(int[] array)
{
    int num = 0;
    for(int i = 0; i < array.Length; i++)
         if(array[i]%2==0)
         num+=1;
    return num; 
}

int[] myArray = CreateArray(6);
ShowArray(myArray);
int number =  NumberOfEven(myArray);
Console.WriteLine("Number of even is " + number );
