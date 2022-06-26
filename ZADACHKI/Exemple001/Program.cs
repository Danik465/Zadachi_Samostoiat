internal class Program
{
    private static void Main(string[] args)
    {
    //Рассчитать значение у при заданном значении х:
    //y=sin(x) при x>0 или y=cos(x) в противном случае.
    
        // Console.WriteLine("Задача 1");
        // Console.WriteLine("Введите число!");
        // double x = Convert.ToInt32(Console.ReadLine());
        // double y = 0; 
        // if (x>0) y = Math.Sin(x);
        // else y = Math.Cos(x);

        // Console.WriteLine(y);

        // Console.WriteLine("--------");
        // Console.WriteLine("Задача 2");

        //Дано число n. Из чисел 1, 4, 9, 16, 25, … 
        //напечатать те, которые не превышают n.

        int [] array = new int[10];

         CreateMassiv(array);
        //  PrintMassiv(array);
         NumberMin(array, 5);
        void CreateMassiv(int[] collection)
        {
            int index = 0;
            int length = collection.Length;
            
            while (index< length)
            {
                collection[index] = new Random().Next(1,10);
                index++;
            } 
           
        }

        // void PrintMassiv(int[] col)
        // {
        //     int count = col.Length;
        //     int pos = 0;
        //     while (pos < count)
        //     {
        //         Console.Write(col[pos] + " ");
        //         pos++;
        //     }
        // }
    
        void NumberMin(int[] mas, int n)
        {
            int lengh = mas.Length;
            int i = 0;

            while (i < lengh)
            {
                if (mas[i] <= n)
               {
                    Console.Write(mas[i] + " ");
                    i++;
               }
            } 


        }
    
    }
}