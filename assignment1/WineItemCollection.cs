//Evan Schober
//CIS 237
//1/21/17
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    static class WineItemCollection
    {
        public static void Add(WineItem[] wineCollection)
        {
            
        }

        public static string Search(WineItem[] wineCollection)
        {
            foreach (WineItem wineItem in wineCollection)
            {
                //if (input == wineItem.ItemId.ToString())
                //{
                //    return wineItem.ItemId.ToString();
                //}
            }

            return ("Item not Found");
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
