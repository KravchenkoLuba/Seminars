//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
double[] CreateRealNumberArray(int size)
{
    double[] array = new double [size];

    for(int i = 0; i<size; i++)
        array[i] = new Random().Next(0,100) + new Random().NextDouble();
        
    return array;
}

void ShowArray(double[] array)
 {
    for(int i = 0; i< array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();

 }

double FindDiff(double[] array)
{
    double minimum = array[0];
    double maximum = array[0];
    
    for(int i = 0; i < array.Length; i++)
    {   
        if(array[i] > maximum) maximum = array[i];
        if(array[i] < minimum) minimum = array[i];
    }
    double diff = maximum - minimum;
    return diff;
    
}

double[] RNArray =  CreateRealNumberArray(7);
ShowArray(RNArray);
double difference = FindDiff(RNArray);
Console.WriteLine("The difference between min and max is " + FindDiff(RNArray));
