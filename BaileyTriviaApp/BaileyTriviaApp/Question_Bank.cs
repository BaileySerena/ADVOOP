using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaileyTriviaApp
{
    class Question_Bank
    {
        const int NO_OF_QUESTIONS = 15;

        const int NO_OF_ANSWERS = 4;

        Question_Unit[] questionBank = new Question_Unit[NO_OF_QUESTIONS];

        string fileName = "Trivia.txt";

        public Question_Bank()
        {
        }

        public string[] GetAnswers(int index)
        {
            return questionBank[index].Answer;
        }

        public string GetCorrectAnswer(int index)
        {
            return questionBank[index].CorrectAnswer;
        }

        public string GetExplanation(int index)
        {
            return questionBank[index].Explanation;
        }

        public string GetQuestion(int index)
        {
            return questionBank[index].Question;
        }

        public int ReadQuestionFile()
        {
            int index = 0;
            StreamReader streamReader = new StreamReader(fileName);

            for (string i = streamReader.ReadLine(); i != null; i = streamReader.ReadLine())
            {
                questionBank[index] = new Question_Unit();
                questionBank[index].Question = i;

                for (int x = 0; x < NO_OF_ANSWERS; x++)
                {
                    questionBank[index].Answer[x] = streamReader.ReadLine();
                }

                questionBank[index].CorrectAnswer = streamReader.ReadLine();
                questionBank[index].Explanation = streamReader.ReadLine();

                index++;
            }

            return index;
        }

        public void AddQuestion(string question, string ansA, string ansB, string ansC, string ansD, string correct, string explain)
        {
            string questionN = question;
            string answerA = ansA;
            string answerB = ansB;
            string answerC = ansC;
            string answerD = ansD;
            string correctAnswer = correct;
            string explanation = explain;

            List<string> entries = new List<string>();
            entries = File.ReadAllLines(fileName).ToList();
            entries.Add(questionN);
            entries.Add(answerA);
            entries.Add(answerB);
            entries.Add(answerC);
            entries.Add(answerD);
            entries.Add(correctAnswer);
            entries.Add(explanation);

            File.WriteAllLines(fileName, entries);
        }
    }
}
