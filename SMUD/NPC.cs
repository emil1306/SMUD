using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUD
{
    class NPC
    {
        public static bool a;
        public static string Answer;

        

        public static bool q(Question q1)
            {
            Console.WriteLine(q1.QuestionText);
            Console.WriteLine();

            Console.WriteLine("Svarmuligheder:");
            Console.WriteLine("z:    " + q1.PossibleAsnwers1);
            Console.WriteLine("x:    " + q1.PossibleAsnwers2);
            Console.WriteLine("c:    " + q1.PossibleAsnwers3);
            Console.WriteLine("v:    " + q1.PossibleAsnwers4);
            Console.WriteLine();

            Console.WriteLine("Indtast dit svar");
            char AnswerInput = Console.ReadKey(true).KeyChar;
            
            if (AnswerInput == 'z') Answer = q1.PossibleAsnwers1;
            else if (AnswerInput == 'x') Answer = q1.PossibleAsnwers2;
            else if (AnswerInput == 'c') Answer = q1.PossibleAsnwers3;
            else if (AnswerInput == 'v') Answer = q1.PossibleAsnwers4;
            else Console.WriteLine("Idiot");
            Console.WriteLine();

            if (Answer == q1.Answer)
            {
                Console.WriteLine("Rigtigt svar");
                a = true;
                
            }
            else
            {
                Console.WriteLine("Forkert svar");
                a = false;
                
            }

            return a;

            }


        
        
        
}
}
