// Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

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

int WordsOfVowelLetter(string[] array)
{
    int counter = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i][0]=='a' || array[i][0]=='e' || array[i][0]=='i' || array[i][0]=='o' || array[i][0]=='u' || array[i][0]=='y')
            counter++;
    }
    return counter;
}

string[] myArray = GreateStringArray(5);
int count = WordsOfVowelLetter(myArray);
ShowStringArray(myArray);
Console.WriteLine(count);


