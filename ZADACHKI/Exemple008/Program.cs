internal partial class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[5];

        void CreateArray(int[] arr)
        {   
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Random().Next(1,20);
            }
        }

        void PrindArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ " ");
            }
        }

        void SortArray(int[] arr)
        {
            

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int MinPosition = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[MinPosition]) MinPosition = j; 
                }

                int temp = arr[i];
                arr[i] = arr[MinPosition];
                arr[MinPosition] = temp;
                
            }
        }


        Console.WriteLine("Массив случайный, не отсортированный");
        CreateArray(array);
        PrindArray(array);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Массив случайный, отсортированный");
        SortArray(array);
        PrindArray(array);
    }
}