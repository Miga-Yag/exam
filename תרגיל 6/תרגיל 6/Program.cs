using System;

namespace תרגיל_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static Fruit IDKwHATisThis(Fruit[] arr)
        {
            Fruit mostExpensive = arr[0];
            for(int i = 1; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].GetSeasons().Length; j++)
                {
                    if (arr[i].GetPrice() > mostExpensive.GetPrice() && arr[i].GetSeasons()[j] == "winter")
                        mostExpensive = arr[i];
                }
            }

            return mostExpensive;
        }
    }
}
