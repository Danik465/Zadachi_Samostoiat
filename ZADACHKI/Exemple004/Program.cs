internal partial class Program
{
    private static void Main(string[] args)
    {
       // Вывести на экран все целые числа от 100 до 200, кратные трем

        multiple(100, 200, 4);

       void multiple(int args1 , int args2, int n)
       {
        
        

            while (args1 <=args2)
            {
                if (args1 % n == 0)
                {
                    Console.Write(args1 + " ");
                }
                    
                    args1++;
            }



        //Найти сумму положительных нечетных чисел, меньших 50.

            int[] array =  new int[10];

           Summ(array, 50);
           void Summ(int[] array, int numb)
           {
           
            int len = array.Length;
            int pos = 0;

                while (pos < len)
                {
                    array[pos] = new Random().Next(-50, 50);
                    if ((array[pos] > 0 && array[pos] != 0 && array[pos] < numb))
                    {
                        Console.Write(array[pos] + " ");
                    }
                    
                    pos++;
                }
           }
       }
    }
}