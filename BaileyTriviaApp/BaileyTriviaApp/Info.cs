using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaileyTriviaApp
{
    class Info
    {
        public void DisplayInfo(string assignment)
        {
            const string AST = " ************************************************";

            Console.WriteLine(AST);
            Console.WriteLine();
            Console.WriteLine("Name:\t\tSerena Bailey");
            Console.WriteLine("Assignment:\t" + assignment);
            Console.WriteLine("Date:\t\t" + DateTime.Today.ToShortDateString());
            Console.WriteLine();
            Console.WriteLine(AST);
        }
    }
}
