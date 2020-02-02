using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaileyTriviaApp
{
    class Question_Unit
    {
        private string question;

        private string[] answer = new string[4];

        private string correctAnswer;

        private string explanation;

        public Question_Unit()
        {
        }

        public string[] Answer
        {
            get
            {
                return answer;
            }
            set
            {
                answer = value;
            }
        }

        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }
            set
            {
                correctAnswer = value;
            }
        }

        public string Explanation
        {
            get
            {
                return explanation;
            }
            set
            {
                explanation = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }
            set
            {
                question = value;
            }
        }
    }
}
