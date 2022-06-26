internal partial class Program
{
    private static void Main(string[] args)
    {
        //Составить программу поиска четырехзначных чисел, 
        //которые при делении на 47 дают в остатке 43, а при делении на 43 дают в остатке 37.


        int[] array = new int[5000];

        FourDigit(array);
        void FourDigit(int[] array)
        {
            int i = 0;
            int len = array.Length; 

            while (i < len)
            {
                array[i] = new Random().Next(1000, 9999);
              
                if (i/1000 == 1 && i % 47 == 43) 
                    {
                        Console.Write("1. ");
                        Console.Write(array[i] + " ");
                       
                    }
                else if (i/1000 == 1 && i % 43 == 37)
                    {
                       Console.Write("2. ");
                       Console.Write(array[i] + " "); 
                    }

                i++;

            }

        }
    }
}