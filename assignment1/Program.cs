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

            //Create the wine collection
            WineItem[] wineCollection = new WineItem[5000];

            //Output Program Header
            ui.Output("************************************************************" + Environment.NewLine +
            "******                  Wine HQ                       ******" + Environment.NewLine +
            "*******        Wine Collection Management            *******" + Environment.NewLine +
            "************************************************************" + Environment.NewLine);

            string csvFile = "../../../datafiles/WineList.csv"; //Path to CSV File

            //Prompt for UserInput
            int choice = ui.UserInput();
            bool CSVLoaded = false;

            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        //If the CSV has already been loaded
                        if (CSVLoaded)
                        {
                           //Output an error and return to the UI
                           ui.Output("This action only needs to be performed once.");
                           choice = ui.UserInput();
                        }
                        else
                        { 
                           //Otherwise load in the CSV file
                           CSVProcessor readFile = new CSVProcessor();
                           //Set CSVLoaded if read operation was successful
                           CSVLoaded = readFile.ImportCSV(csvFile, wineCollection);
                           choice = ui.UserInput();
                        }
                        break;
                    case 2:
                        //Output the full list of available wines.
                        ui.Output(WineItemCollection.GetPrintString(wineCollection)); 
                        choice = ui.UserInput();
                        break;
                    case 3:
                        //Search Array
                        //WineItemCollection.Search(wineCollection);
                        ui.Output("Search Function Pending");
                        choice = ui.UserInput();
                        break;
                    case 4:
                        //Add item
                        ui.Output("Add Function Pending");
                        choice = ui.UserInput();
                        break;
                    default:
                        //Output the error if there is a numerical input that is not 1-5
                        ui.Output("Error: Please enter valid numeric entry (1-5)");
                        choice = ui.UserInput();
                        return;

                }
            }
            //If UI input = 5 display farewell and close the program
            ui.Output("Goodbye!");
        }
    }
}
