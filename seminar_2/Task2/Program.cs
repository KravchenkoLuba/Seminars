void ThirdDigit()
{
    int number = new Random().Next(1,1000000);
    Console.WriteLine("Our current number is  " + number);
    
    int res = number % 10;
    int res1 = number % 100 / 10;
    int res2 = number % 1000 / 100;
    int res3 = number % 10000 / 1000;
    
    if(number < 100)
       Console.WriteLine("There is no third digit");
    else   
        if(number>99 && number<1000) 
            Console.WriteLine(res);
    
        if(number>1000 && number<10000)
            Console.WriteLine(res1);
   
        if(number>10000 && number<100000)
            Console.WriteLine(res2);
    
        if(number>100000 && number<1000000)
            Console.WriteLine(res3);
}

ThirdDigit();