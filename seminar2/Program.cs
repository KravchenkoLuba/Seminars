int TwoNumbers()
{
    int rand = new Random().Next(100, 1000);
    Console.WriteLine("Our current number is " + rand);
    int sot = rand/100;
    int ed = rand % 10;
    int result = sot*10 + ed*1;
    return result;
}
/*
int a = TwoNumbers();
Console.WriteLine("result number is " + a);
*/

int RemainderOfDivision(a, b);
{
if(b / a == 0)
 {
    Console.WriteLine("Multiple");
    return 0;
 }
else
{
    Console.WriteLine("Not Multiple");
    
}


}

 Console.WriteLine("Input first number:  ");
 a = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Input second number:  ");
 b = Convert.ToInt32(Console.ReadLine());


 
