internal class Program
{
    private static void Main(string[] args)
    {
        int[,,] mas = { { { 1, 2 },{ 3, 4 } }, 
                { { 4, 5 }, { 6, 7 } }, 
                { { 7, 8 }, { 9, 10 } }, 
                { { 10, 11 }, { 12, 13 } }
              };

                FillArray(mas);
              void FillArray(int[,,] arr)
              {
                int row = arr.GetLength(0);
                int colms = arr.GetLength(1);
                int widgh = arr.GetLength(2);

                for (int i = 0; i < row; i++)
                { 
                    for (int j = 0; j < colms; j++)
                    {
                       
                        for (int k = 0; k < widgh; k++)
                        {
                            Console.Write(arr[i,j,k]+ " ") ;
                        }
                         Console.WriteLine();
                    }
                     Console.WriteLine();
                }
              }
    }
}