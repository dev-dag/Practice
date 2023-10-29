namespace rubtub2314
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography;
    using rubtub2314.Logic.Sort;

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 1, 7, 5, 84, 44, 2, 7, 33 };
            
            var ascendingSortedArray = QuickSort.Sort(arr, SortMethodEnum.Ascending);
            var descendingSortedArray = QuickSort.Sort(arr, SortMethodEnum.Descending);

            Console.WriteLine("오름차 순 정렬");
            ToString(ascendingSortedArray);

            Console.WriteLine("내림차 순 정렬");
            ToString(descendingSortedArray);
        }

        private static void ToString(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();
            return;
        }
    }
}
