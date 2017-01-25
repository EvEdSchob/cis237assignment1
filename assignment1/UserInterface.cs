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
            string query = null;
            Console.Write(Environment.NewLine + "Enter Item ID:");
            query = Console.ReadLine().ToString();
            while(query.Length != 5)
            {
                Console.WriteLine("Invalid query length. Item IDs are 5 characters.");
                query = SearchInput();
            }
            return query.ToUpper();
        }

        public string AddItem()
        {
            
            return null;
        }

        public void Output(string outputString)
        {
            Console.WriteLine(outputString);
        }

        public void LoadCSV()
        {
            Console.WriteLine("Array not found. Please load a CSV file.");
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
