using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_3
{
    class Coach
    {
        private string name;
        private Subscriber[] subsArr;
        private int numOfSubs;
        private int[] cntArr;

        public Coach(string name)
        {
            this.name = name;
            this.subsArr = new Subscriber[20];
            this.numOfSubs = 0;
            this.cntArr = new int[5];
        }

        public int AddSubscriber(Subscriber subscriber)
        {
            if (this.numOfSubs == 20)
                return 0;

            if (this.cntArr[subscriber.GetDay() - 1] == 4)
            {
                for(int i = 0; i < this.cntArr.Length; i++)
                {
                    if(this.cntArr[i] < 4)
                    {
                        this.subsArr[this.numOfSubs] = subscriber;
                        this.numOfSubs++;
                        this.cntArr[i]++;
                        return i + 1;
                    }
                }
            }

            this.subsArr[this.numOfSubs] = subscriber;
            this.numOfSubs++;
            this.cntArr[subscriber.GetDay() - 1]++;
            return subscriber.GetDay();
        }
    }
}
