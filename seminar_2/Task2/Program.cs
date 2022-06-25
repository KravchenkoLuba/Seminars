void ThirdDigit(int number)
{
    if(number>99 && number<1000)
    res = number%10;
    Console.WriteLine(res);
    elif(number>1000 && number<10000);
    int res1 = number%100/10;
    Console.WriteLine(res);
    elif(number>10000 && number<100000);
    int res2 = number%1000/100;
    Console.WriteLine(res);
    elif(number>100000 && number<1000000);
    int res3 = number%10000/1000;
    Console.WriteLine(res);
    
    
Console.WriteLine("There is no third digit");
}

int number = Random.Next(1,1000000);
Console.WriteLine(number);
ThirdDigit(number);
