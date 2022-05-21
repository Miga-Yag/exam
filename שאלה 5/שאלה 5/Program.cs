using System;

namespace שאלה_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int HigherThenAvg(Jumper jumper)
        {
            double avg = jumper.GetResultsAvg();
            int counter = 0;
            for(int i = 0; i < jumper.GetResults().Length; i++)
            {
                if (jumper.GetResults()[i] > avg)
                    counter++;
            }

            return counter;
        }
    }
}
