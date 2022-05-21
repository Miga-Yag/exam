using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_4
{
    class NextRoom
    {
        private string name;
        private int roomNum;


        public NextRoom(string name, int roomNum)
        {
            this.name = name;
            this.roomNum = roomNum;

        }

        //Get
        public string GetName()
        {
            return this.name;
        }
        public int GetRoomNum()
        {
            return this.roomNum;
        }
    }
}
