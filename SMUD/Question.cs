using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMUD
{
    public class Question
    {
        public string QuestionText;
        public string PossibleAsnwers1;
        public string PossibleAsnwers2;
        public string PossibleAsnwers3;
        public string PossibleAsnwers4;
        public QuestionType QT1;
        public string Answer;

        public Question(string Question, string possibleAnswer1, string possibleAnswer2, string possibleAnswer3, string possibleAnswer4, QuestionType QT2, string Answer)
        {
            this.QuestionText = Question;
            this.PossibleAsnwers1 = possibleAnswer1;
            this.PossibleAsnwers2 = possibleAnswer2;
            this.PossibleAsnwers3 = possibleAnswer3;
            this.PossibleAsnwers4 = possibleAnswer4;
            this.QT1 = QT2;
            this.Answer = Answer;
        }

        public void Addqt(QuestionType q)
        {
            QT1 = q;
        }

        public enum QuestionType
        {
            GM,
            Mat,
            FK,
            Da
        }
        


}
}
