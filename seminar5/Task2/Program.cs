//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] CreateArray(int size)
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
 
 int SumElementsOfUP(int[] array)
 {
    int sum = 0;
    for(int i = 1; i < array.Length; i+=2)
    sum+=array[i];
    return sum;
 }

 Console.Write("Input size array: ");
 int size = Convert.ToInt32(Console.ReadLine());

 int[] ourArray =  CreateArray(size);
 ShowArray(ourArray);
 int summ = SumElementsOfUP(ourArray);
 Console.WriteLine("The sum of the array elements standing in odd positions is " + summ);
 