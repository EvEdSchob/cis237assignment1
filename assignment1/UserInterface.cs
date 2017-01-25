//Evan Schober
//CIS 237
//1/21/17
//
//Controls the user interface.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class UserInterface
    {
        //No Variables
        //No Properties
        //No Constructors

        //********************************
        //Methods
        //********************************
        public int UserInput()
        {
            displayMenu();

            string input = Console.ReadLine();

            try
            {
                return Int32.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);
                return 0;
            }
        }

        public string SearchInput()
        {
            return null;
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        private void displayMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Load wine list");
            Console.WriteLine("2. Print wine list");
            Console.WriteLine("3. Search for an item");
            Console.WriteLine("4. Add a new wine");
            Console.WriteLine("5. Exit" + Environment.NewLine);
            Console.Write("Make a selection: ");
        }
    }
}
