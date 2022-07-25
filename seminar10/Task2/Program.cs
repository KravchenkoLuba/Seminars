// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
string[] GreateStringArray(int number)
{
    string[] stringArray = new string[number];
    for(int i = 0; i < number; i++)
    {
        Console.Write($"Input {i+1} name ");
        stringArray[i] = Console.ReadLine();
    }
    return stringArray;
}

void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] CombineElementsArrays(string[] array)
{
    string[] array1 = new string[array.Length];
    for(int i = 0; i < array.Length; i+=2)
    {
        array1[i] = array[i] + array[i+1];
    }
    return array1;
}

string[] firstArray = GreateStringArray(6);
string[] secondArray = CombineElementsArrays(firstArray);
ShowStringArray(firstArray); 
ShowStringArray(secondArray);