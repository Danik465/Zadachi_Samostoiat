internal class Program
{
    private static void Main(string[] args)
    {
        //Среди чисел 1, 4, 9, 16, 25, … найти первое число, большее n.


        int[] array = {1,2,4,5,67,11,6};
        int index = 0;
        int n = array.Length;
        Console.WriteLine("Введите число");
        int number = Convert.ToInt32(Console.ReadLine());
        while (index < n)
        {
            if (number < array[index])
            {
                Console.WriteLine(array[index]);
                break;
            }
            index++;
        }
    }
}