internal class Program
{
    private static void Main(string[] args)
    {
        int[][] arrays = new int[3][];

        arrays[0] = new int[5] {1,2,3,4,5};
        arrays[1] = new int[3] {1,2,3};
        arrays[2] = new int[2] {1,2};

         for (int i = 0; i < arrays.Length; i++)
        {
            System.Console.Write("Element({0}): ", i);

            for (int j = 0; j < arrays[i].Length; j++)
            {
                System.Console.Write("{0}{1}", arrays[i][j], j == (arrays[i].Length - 1) ? "" : " ");
            }
            System.Console.WriteLine();
        }
        // Keep the console window open in debug mode.
        System.Console.WriteLine("Press any key to exit.");
        System.Console.ReadKey();

    }
}