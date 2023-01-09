using System;

namespace lab4ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex 4
             Scrieti o functie recursiva care va afisa in ordine elementele unui vector de
             intregi.
             */
            int[] arr = new int[] { 9, 3, 4, 5, 1, 2, 3, 6, 7, 8 };

            int[] orderedArr = RecursiveFunction(arr);

            for (int i = 0; i < orderedArr.Length; i++)
            {
                Console.WriteLine($"Numerele ordonate sunt:{orderedArr[i]}");
            }

            static int[] RecursiveFunction(int[] arr)
            {
                int temp;
                int index = 0;
                if (IsOrdered(arr))
                {
                    return arr;
                }

                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;

                    }
                    index = arr.Length + 1;
                }

                return RecursiveFunction(arr);

            }

            static bool IsOrdered(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
