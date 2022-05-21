using System;

namespace שאלה_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] Count(int[] a)
        {
            int[] arr = new int[1000];
            for(int i = 0; i < a.Length; i++)
            {
                arr[a[i] - 1]++;
            }

            int counter = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    counter++;
            }

            int[] b = new int[counter];
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == 0)
                {
                    b[i] = i + 1;
                }
            }

            return b;
        }
    }
}
