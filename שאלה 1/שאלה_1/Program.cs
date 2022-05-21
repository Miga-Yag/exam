using System;

namespace שאלה_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        public static int GetOldestSeniority(BalletDancer[] b)
        {
            BalletDancer dancer = b[0];
            for(int i = 1; i < b.Length; i++)
            {
                if (b[i].GetSeniority() > dancer.GetSeniority())
                    dancer = b[i];
                if (b[i].GetSeniority() == dancer.GetSeniority() && b[i].GetBirth() < dancer.GetBirth())
                    dancer = b[i];
            }

            return dancer.GetBirth();
        }

        public static int GetCommonSeniority(BalletDancer[] b)
        {
            int[] seniority = new int[10];
            for(int i = 0; i < b.Length; i++)
            {
                seniority[b[i].GetSeniority() - 1]++;
            }

            int max = 0;
            int result = 0;
            for(int i = 0; i < seniority.Length; i++)
            {
                if(seniority[i] > max)
                {
                    max = seniority[i];
                    result = i + 1;
                }
            }
            return result;
        }
    }
}
