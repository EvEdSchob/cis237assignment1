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
        //****************************************
        //Variables
        //****************************************
        string csvFile = "../../../datafiles/WineList.csv";
        StreamReader streamReader = null;

        //***************************************
        //Methods
        //***************************************
        private void ReadFile()
        {
            streamReader = new StreamReader(csvFile);
        }


        //***************************************
        //Constructors
        //***************************************
        public CSVProcessor()
        {
            ReadFile();
        }        
    }
}
