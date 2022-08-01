internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[20];
        CreateMassiv_1(array);
        PrintMassiv_1(array, 625);
        //int n = 25;

        void CreateMassiv_1(int[] mass)
        {
            int len = array.Length;
            int ind = 0;

            while (ind < len)
            {
                mass[ind] =  new Random().Next(1,50);
                ind++;
            }
        }
    
        void PrintMassiv_1(int[] massiv, int n)
        {
            int i = 0;
            int collection = massiv.Length;

            while (i < collection)
            {
                if(Math.Pow(array[i], 2)> n)
                {
                Console.Write(massiv[i] + " ");
                break;
                }
                i++;
            }

        }

       
    //     int n =25;
    //     int[] array = new int[20];
    //     CreateMassiv(array);
    //     void CreateMassiv(int[] mass)
    //     {
    //        int len = array.Length;
    //        int i = 0;
    //        while (i < len)
    //        {
    //             mass[i] = new Random().Next(1,20);
    //        }
    //     }
    //     int index = 0;
    //     int len = array.Length;
    //     while (index < len)
    //     {
    //         Console.Write(array[index]);
    //         index++;
    //     }

       
   
    }
}