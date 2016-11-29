using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUD
{
    class Player
    {
        
        public static int HP = 100;
        public static Room CurrentRoom = Program.w.rooms.ElementAt(0);
        public static List<Item> Inventory = new List<Item>();


        public static void PlayerMove()
        {
            string input = Convert.ToString(Console.ReadKey(true).KeyChar);
            if (input == "w" && Player.CurrentRoom.north != null)
            {
                Player.CurrentRoom = Player.CurrentRoom.north;
            }
            else if (input == "a" && Player.CurrentRoom.west != null)
            {
                Player.CurrentRoom = Player.CurrentRoom.west;
            }
            else if (input == "s" && Player.CurrentRoom.south != null)
            {
                Player.CurrentRoom = Player.CurrentRoom.south;
            }
            else if (input == "d" && Player.CurrentRoom.east != null)
            {
                Player.CurrentRoom = Player.CurrentRoom.east;
            }
            else
            {
                Console.WriteLine("Der er intet rum i denne retning");
            }
        }
    }
}
