//Evan Schober
//CIS 237
//1/21/17
//
//Main Line: Controls instantiation of an communication between all other classes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of the UI
            UserInterface ui = new UserInterface();

            ui.Output("************************************************************" + Environment.NewLine +
            "******                  Wine HQ                       ******" + Environment.NewLine +
            "*******        Wine Collection Management            *******" + Environment.NewLine +
            "************************************************************" + Environment.NewLine + Environment.NewLine);

            //Prompt for UserInput
            int choice = ui.UserInput();
            int CSVcounter = 0;

            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        if (CSVcounter > 0)
                        {
                            ui.Output("This action only needs to be performed once.");
                            ui.UserInput();
                        }
                        CSVProcessor readFile = new CSVProcessor();
                        break;
                    case 2:
                        string outputString = "";

                        foreach (WineItem wineItem in wineList)
                        {
                            if (wineItem != null)
                            {
                                //Concantonate to outputString
                                outputString += wineItem.ToString() +
                                    Environment.NewLine;
                            }

                        }
                        ui.Output(outputString);
                        break;
                    case 3:
                        //Search Array
                        break;
                    case 4:
                        //Add item
                        break;
                    default:
                        ui.Output("Error: Please enter valid numeric entry (1-5)");
                        ui.UserInput();
                        return;

                }
            }
        }
    }
}
