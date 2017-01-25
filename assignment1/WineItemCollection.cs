//Evan Schober
//CIS 237
//1/21/17
//
//Manages the Array wineCollection Add, Search and Print String

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    static class WineItemCollection
    {
        public static void Add(string AddValue, WineItem[] wineCollection)
        {
            //int x = 0;
            //while(wineCollection[x] != null)
            //{
            //    x++;
            //}
            //CSVProcessor addItem = new CSVProcessor.readLine();
        }

        public static string Search(string SearchInput, WineItem[] WineCollection)
        {
            foreach (WineItem wineItem in WineCollection)
            {
                if (wineItem == null)
                    return "Item not found";
                if(SearchInput == wineItem.ItemId)
                    return wineItem.ToString();
            }
            return null;
        }

        public static string GetPrintString(WineItem[] WineCollection)
        {
            string outputString = "";

            foreach (WineItem wineItem in WineCollection)
            {
                if (wineItem != null)
                {
                    //Concantonate to outputString
                    outputString += wineItem.ToString() +
                        Environment.NewLine;
                }

            }
            return outputString;
        }
    }
}
