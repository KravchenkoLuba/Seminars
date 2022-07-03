//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreatArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i<size; i++)
        array[i] = new Random().Next(0,100);
        
    return array;
}

 void ShowArray(int[] array)
 {
    for(int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

 }
 
 Console.Write("Input size array: ");
 int size = Convert.ToInt32(Console.ReadLine());

 int[] ourArray =  CreatArray(size);
 ShowArray(ourArray);
 