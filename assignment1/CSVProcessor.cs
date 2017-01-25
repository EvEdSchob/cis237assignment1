//Evan Schober
//CIS 237
//1/21/17
//
//Reads a list of wine items

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace assignment1
{
    class CSVProcessor
    {
        public bool ImportCSV(string pathToCSVFile, WineItem[] wineCollection)
        {
            StreamReader streamReader = null;

            try
            {
                string line;

                streamReader = new StreamReader(pathToCSVFile);

                int counter = 0;


                //While records are able to be read
                while ((line = streamReader.ReadLine()) != null)
                {
                    //Read a record
                    readLine(line, wineCollection, counter++);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {
                if(streamReader != null)
                {
                    streamReader.Close();
                }
            }
        }


        public void readLine(string line, WineItem[] wineCollection, int index)
        {
            //Split array to hold parts of the record just read in
            string[] split = line.Split(',');

            //Temp storage variables
            string itemId = split[0];
            string description = split[1];
            string pack = split[2];

            //Pass split parts into the array
            wineCollection[index] = new WineItem(itemId, description, pack);
        }    
    }
}
