void ThirdDigit(int number)
{
 int res = number%10;

 if(number < 100)
     Console.WriteLine("There is no third digit");
      
 else 
      if(number<1000)
      Console.WriteLine(res);
  

     if(number>999)  
        while(number>999)
        {
          number = number/10;
          res=number%10;   
          Console.WriteLine(res);
        }       
}


Console.WriteLine("Input number ");
int number = Convert.ToInt32(Console.ReadLine());
ThirdDigit(number);
   
    
            