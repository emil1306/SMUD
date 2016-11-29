using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUD
{
    class Program
    {
        public static Random getrand = new Random();
        public static World w = new World();
        static void Main(string[] args)
        {
            
            while(Player.HP > 0)
            {
                if(Player.CurrentRoom == w.rooms.ElementAt(0)) Player.PlayerMove();

                if (Player.CurrentRoom == w.rooms.ElementAt(1))
                {
                    if (NPC.q(w.questions.ElementAt(0)))
                    {
                        Player.HP += getrand.Next(1, 20);
                        if (NPC.q(w.questions.ElementAt(1)))
                        {
                            if (NPC.q(w.questions.ElementAt(2)))
                            {
                                if (NPC.q(w.questions.ElementAt(3)))
                                {

                                }
                                else Player.CurrentRoom = w.rooms.ElementAt(0);
                            }
                            else Player.CurrentRoom = w.rooms.ElementAt(0);
                        }
                        else
                        {
                            Player.CurrentRoom = w.rooms.ElementAt(0);
                            Player.HP -= getrand.Next(50, 99);
                        }
                    }
                    else
                    {
                        Player.CurrentRoom = w.rooms.ElementAt(0);
                        Player.HP -= getrand.Next(50, 99);
                    }
                }
                else Player.CurrentRoom = w.rooms.ElementAt(0);

                Console.WriteLine("HP = " + Player.HP);


            }
            
        }
    }
}
