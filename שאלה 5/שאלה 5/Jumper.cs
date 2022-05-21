using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_5
{
    class Jumper
    {
        private string name;
        private double[] results;

        public Jumper()
        {
            this.name = "";
            this.results = new double[10];
        }


        public double GetResultsAvg()
        {
            double sum = 0;
            for(int i = 0; i < this.results.Length; i++)
            {
                sum += this.results[i];
            }

            return sum / 10;
        }

        public double[] GetResults() { return this.results; }
    }
}
