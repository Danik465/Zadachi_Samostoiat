internal partial class Program
{
    private static void Main(string[] args)
    {
         int mult = 1;
                int number = 233;
                while (number != 0)
                {
                    
                    mult = mult * (number%10);
                  
                    number = number / 10;
                }
                Console.WriteLine(mult);
    }
}