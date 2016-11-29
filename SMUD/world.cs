using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUD
{
    public class World
    {
        public List<Room> rooms;
        public List<Question> questions;
        
        public World()
        {
            rooms = new List<Room>();

            Room r1 = new Room("Ingenmandsland", "test beskrivelse");

            Room r2 = new Room("Georg Mohr", "");

            Room r3 = new Room("Dansk", "");

            Room r4 = new Room("Fysik/Kemi", "");

            Room r5 = new Room("","");

            rooms.Add(r1);
            rooms.Add(r2);
            rooms.Add(r3);
            rooms.Add(r4);
            
            r1.AddEast(r2);
            r1.AddSouth(r3);
            r1.AddWest(r4);
            r2.AddWest(r1);
            r2.AddNorth(r3);
            r3.AddSouth(r2);
            r3.AddEast(r4);


            questions = new List<Question>();

            Question q1 = new Question("En flue siger til sig selv: I morgen er det onsdag, og der er jeg dobbelt så gammel som jeg var i fredags.Hvor mange dage gammel er fluen i dag","5","7","8","9",Question.QuestionType.GM,"9");
            Question q2 = new Question("Om tre positive tal x, y og z ved vi at 2x > 3y > 4z .Hvad kan med sikkerhed sluttes ?", "x < y < z", "x > 2y > 3z", "3x > 4y > 5z", "3x > 5y > 7z", Question.QuestionType.GM, "3x > 4y > 5z");
            Question q3 = new Question("Georg slår plat eller krone med en mønt. Efter hvert kast skriver han A hvis han fik krone, og B hvis han fik plat.Hver gang tilføjer han det nye bogstav efter det foregående.Efter fire kast har han et ord på fire bogstaver.Hvilket af følgende ord er der størst sandsynlighed for at han har?", "BBAB", "ABAB", "AAAA", "Alle ordene er lige sandsynlige", Question.QuestionType.Da, "Alle ordene er lige sandsynlige");
            Question q4 = new Question("nders, Benjamin, Carla og Dagmar taler hver især enten altid sandt eller lyver altid. /nDe siger: /nAnders: Dagmar lyver./nBenjamin: Carla lyver./nDagmar: Den ene af Benjamin og Carla taler sandt, mens den anden lyver./nHvem ved vi med sikkerhed altid lyver?", "Anders", "Benjamin", "Dagmar", "Alle", Question.QuestionType.GM, "Anders");
            Question q5 = new Question("En charmerende rektangulær plads der er 44 meter på den ene led og 88 meter på den anden led, er belagt med smukke kvadratiske fliser der alle er lige store.Georg røber at antallet af fliser er et af følgende fem tal.Hvilket?", "2000", "10000", "11000", "20000", Question.QuestionType.GM, "20000");
            Question q6 = new Question("Georg tænker på et helt tal. Først ganger han tallet med 5, og derefter trækker han 7 fra resultatet.Så ganger han det nye resultat med 9 og får tallet x .Hvad kan man med sikkerhed slutte om x?", "x er ulige", "x er lige", "3 går op i x", "5 går op i x", Question.QuestionType.GM, "3 går op i x");

            //Question q11 = new Question();

            questions.Add(q1);
            questions.Add(q2);
            questions.Add(q3);

            q1.Addqt(Question.QuestionType.GM);
            q2.Addqt(Question.QuestionType.GM);
            q3.Addqt(Question.QuestionType.Da);


        }

        public void PrintWorld()
        {
            foreach (Room r in rooms)
            {
                Console.WriteLine(r.ToString());
            }
        }
        
        
    }
}
