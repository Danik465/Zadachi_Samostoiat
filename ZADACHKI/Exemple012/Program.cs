internal class Program
{
    private static void Main(string[] args)
    {
        // Даны целое число i (1 <= i <= 150) и последовательность цифр
        // 101102103...149150, в которой выписаны подряд все трехзначные числа от 101 до 150.
        // Определить i-ю цифру, если известно, что:
        // k — число, кратное трем;
        // k — одно из чисел 1, 4, 7, ...;
        // k — одно из чисел 2, 5, 8, ...

        

        string numb = "";

        for (int i = 101; i <= 150; i++)
        {
            numb += Convert.ToString(i);

        } 

        int[] array = new int[150];
        
        for (int i = 0; i < numb.Length; i++)
        {
            array[i] = Convert.ToInt32(numb[i]);
        }
                        
       for (int i = 0; i < array.Length; i++)
        {
         Console.Write(array[i]);
        }
        Console.WriteLine();
       
    

        
    }
}