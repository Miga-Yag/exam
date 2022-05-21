using System;
using System.Collections.Generic;
using System.Text;

namespace שאלה_4
{
    class TreasureHunt
    {
        private NextRoom[] arr = new NextRoom[50];


        public void PrintPath(int roomNumber)
        {
            Console.WriteLine(roomNumber);
            int index = this.arr[roomNumber].GetRoomNum();
            while (this.arr[index].GetRoomNum() != -1)
            {
                Console.WriteLine(this.arr[index].GetName() + " | " + this.arr[index].GetRoomNum());
                index = this.arr[index].GetRoomNum();
            }
            Console.WriteLine();
            Console.WriteLine("room num -1 | search in here ;)");
        }
    }
}
