using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaileyTriviaApp
{
    class Questions
    {
            public string QuestionName { get; set; }
            public string AnswerA { get; set; }
            public string AnswerB { get; set; }
            public string AnswerC { get; set; }
            public string AnswerD { get; set; }
            public string CorrectAnswer { get; set; }
            public string Explanation { get; set; }

        public static string GetQuestions(Questions questions)
            {
                string returnValue = questions.QuestionName + "," + questions.AnswerA + "," + questions.AnswerB + "," + questions.AnswerC + questions.AnswerD + "," + questions.CorrectAnswer + "," + questions.Explanation;
                return returnValue;
            }
        }
}
