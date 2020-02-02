using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BaileyTriviaApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Info i = new Info();
            i.DisplayInfo("Trivia Game");

            Controller c = new Controller();
            Question_Bank q = new Question_Bank();

            int choice;

            while (true)
            {
                Console.WriteLine("\n\n\n1.Play Trivia!");
                Console.WriteLine("2.Add a Trivia Question");
                Console.WriteLine("3.Quit the App");

                Console.WriteLine("Please Enter Your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 3)
                    break;

                Console.Clear();

                switch (choice)
                {
                    case 1:
                        c.Play();
                        break;
                    case 2:
                        c.UserInput();
                        break;
                    case 3:
                        c.Exit();
                        break;
                    default:
                        Console.WriteLine("Not a valid option.");
                        break;
                }
            }

            c.Exit();
            Console.ReadLine();
        }

        }
    }