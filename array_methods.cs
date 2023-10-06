using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1-------------------

            //int[] numbers = { 12, 20, 93, 54, 45, 16, 27, 8 };

            //SwapMinMan(numbers);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------
        }
       #region Task 1
        public static void SwapMinMan(int[] numbers)
        {
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[minIndex])
                {
                    minIndex = i;
                }
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int temp = numbers[minIndex];
            numbers[minIndex] = numbers[maxIndex];
            numbers[maxIndex] = temp;
        }
        #endregion
       #region Task 2
        // Baacarmadim :(
        #endregion
    }
}
