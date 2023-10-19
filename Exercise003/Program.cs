// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

internal class Program
{
    private static void Main(string[] args)
    {
        int ReadInPut(string text)
        {
            Console.Write(text);
            return Math.Abs(Convert.ToInt32(Console.ReadLine()));
        }

        int[] FillArray(int Length, int minValue, int maxValue)
        {
            int[] arrayToFill = new int[Length];
            Random rand = new Random();
            for (int i = 0; i < Length; i++)
            {
                arrayToFill[i] = rand.Next(minValue, maxValue + 1);
            }
            return arrayToFill;
        }

        void PrintArray(int[] arrayForPrint)
        {
            Console.Write("[");
            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                Console.Write(arrayForPrint[i] + " ");
            }
            Console.Write("]");
        }
        //------------------
        int length = ReadInPut("Введите длину массива: ");
        int min = ReadInPut("Введите начальное значение: ");
        int max = ReadInPut("Введите конечное значение: ");
        int[] array = FillArray(length, min, max);
        PrintArray(array);
    }
}