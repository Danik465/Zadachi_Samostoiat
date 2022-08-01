internal class Program
{
    private static void Main(string[] args)
    {

        int[] array = {1,14,55,43,1,3,5,2,1,22,1};
        void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

      
        void SelctionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minposition = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if(array[j] > array[minposition]) minposition = j;
                }

                int temp = array[i];
                array[i] = array[minposition];
                array[minposition] = temp;
            }

        }
        PrintArray(array);
        Console.WriteLine();
        SelctionSort(array);
        PrintArray(array);
    }
}