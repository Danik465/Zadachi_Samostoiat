internal partial class Program
{
    private static void Main(string[] args)
    {
        // // Дано натуральное число. Определить:
        // // а) является ли оно четным;
        // // б) оканчивается ли оно цифрой 7.

        // int number = 7457;

        // if(number %10 == 7)
        // {
        //     Console.WriteLine("оканчивается ли оно цифрой 7");
        // }
        // Console.WriteLine("Вторая задача");

        // //  Определить, попадает ли точка с заданными координатами в область I
        // // (рис. 4.4). Для простоты принять, что точка не попадает на границу этой области.

        // int y1 = Convert.ToInt32(Console.ReadLine());
        // int x1 = Convert.ToInt32(Console.ReadLine());


        // int y = 2;
        // int x = 3;


        // if(x1 >= x && y1 >=y)
        // {
        //     Console.Write("Входит в диапазон");
        // }
        // else Console.Write("Не входит");

        //  Даны цифры двух целых чисел: двузначного
        // 2 1 a a
        // и однозначного b, где
        // 1a — число единиц,
        // 2 a — число десятков. Получить цифры числа, равного
        // разности заданных чисел (известно, что это число двузначное). Числоуменьшаемое и число-разность не определять.



        int number1 = 54;
        int number2 = 5;

        int num  = number1 - number2;

        int[] array = new int[2];
        int i = 0;
        int result = 0;

        while (num > 0)
        {
            result = num%10;
             num/=10;
             array[i] = result;
             i++;
        }
       PrintArray(array);
        void PrintArray(int[ ]arr)
        {
            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
        }



    }
}