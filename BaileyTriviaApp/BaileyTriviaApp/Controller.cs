using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaileyTriviaApp
{
    class Controller
    {
        public Controller()
        {
        }

        public void Play()
        {

            string upper = "Y";
            Welcome();

            do
            {
                Console.Clear();

                if (PlayAgain() != 0)
                {
                    Console.Write("\n\nWould you like to play again? (Y or N): ");
                    upper = Console.ReadLine().ToUpper();
                }

                else
                {
                    upper = "N";
                }
            }
            while (upper == "Y");
        }

        public void Welcome()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t-----------------------------------------------------------");
            Console.WriteLine("\t|Let's play a fun game of Trivia!!! How to play is simple!| ");
            Console.WriteLine("\t|You're going to see 4 questions, your job is to pick one!| ");
            Console.WriteLine("\t|Pick the correct answer and you'll get an awesome score!!| ");
            Console.WriteLine("\t-----------------------------------------------------------");
            Console.WriteLine("\n");
            Console.Write("Press the Enter key when you are ready!. Good Luck!! ");
            Console.ReadLine();
        }

        public int PlayAgain()
        {
            int index = 0;
            int questions = 0;
            string[] answers = new string[4];
            Question_Bank questionBank = new Question_Bank();

            try
            {
                questions = questionBank.ReadQuestionFile();
            }
            catch (System.IO.IOException exc)
            {
                Console.WriteLine("\n\n");
                Console.WriteLine(exc.Message);
            }

            int answer = 0;

            while (index < questions)
            {
                Console.WriteLine("\n\n\n");
                Console.WriteLine("Question " + index + ": \n");
                Console.WriteLine(questionBank.GetQuestion(index));

                answers = questionBank.GetAnswers(index);

                Console.WriteLine("\n  A. " + answers[0] + "\t\t\tB. " + answers[1]);
                Console.WriteLine("  C. " + answers[2] + "\t\t\tD. " + answers[3]);
                Console.Write("\n\nWhat is your guess? ");

                string upper = Console.ReadLine().ToUpper();
                string correctAnswer = questionBank.GetCorrectAnswer(index);

                if (upper != correctAnswer)
                {
                    Console.WriteLine("\nSorry! Wrong answer!\nThe correct answer is " + correctAnswer);
                }
                else
                {
                    Console.WriteLine("\nYayy! You are correct!");
                    answer++;
                }

                Console.WriteLine("\n" + questionBank.GetExplanation(index));

                index++;

                Console.WriteLine("\n\n\nPlease press the Enter key when you're ready to continue!");
                Console.ReadLine();
                Console.Clear();
            }

            if (questions != 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n");
                Console.WriteLine("You got " + answer + " correct answers out of " + questions + " questions.");
                Console.WriteLine("This gives you a percentage of {0:P}", (double)answer / (double)questions);
            }

            return questions;
        }

        public void UserInput()
        {
            Question_Bank myQuestions = new Question_Bank();

            Console.Write("\n\nWhat is the question you want to add? \n");
            string question = Console.ReadLine();
            Console.Write("\n\nWhat is the first answer? \n");
            string answerA = Console.ReadLine();
            Console.Write("\n\nWhat is the second answer? \n");
            string answerB = Console.ReadLine();
            Console.Write("\n\nWhat is the third answer? \n");
            string answerC = Console.ReadLine();
            Console.Write("\n\nWhat is the fourth answer? \n");
            string answerD = Console.ReadLine();
            Console.Write("\n\nWhat is the correct answer? (First = A, second = B, third = C, forth = D) \n");
            string correctAnswer = Console.ReadLine().ToUpper();
            Console.Write("\n\nPlease give an explanation for the question and answer. \n");
            string explanation = Console.ReadLine();


            myQuestions.AddQuestion(question, answerA, answerB, answerC, answerD, correctAnswer, explanation);
        }

        public void Exit()
        {
            Console.WriteLine("Thanks for Playing! \n");
            Console.WriteLine("Press Enter to Quit Program.");
        }
    }
}
