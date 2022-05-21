using System;
using System.Collections.Generic;
using System.Text;

namespace תרגיל_6
{
    class Fruit
    {
        private string name;
        private double price;
        private string[] seasons;

        public Fruit(string name, double price, string[] seasons)
        {
            this.name = name;
            this.price = price;
            this.seasons = seasons;
        }


        //Get
        public string GetName()
        {
            return this.name;
        }
        public double GetPrice()
        {
            return this.price;
        }
        public string[] GetSeasons()
        {
            return this.seasons;
        }


        public bool InSeason(string season)
        {
            for(int i = 0; i < this.seasons.Length; i++)
            {
                if (season == this.seasons[i])
                    return true;
            }
            return false;
        }

        public int HowMuchSeasons()
        {
            return this.seasons.Length;
        }
    }
}
