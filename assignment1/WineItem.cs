//Evan Schober
//CIS 237
//1/21/17
//
//Manages the definition of the WineItem object class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        //Variables
        private string _id;
        private string _description;
        private string _pack;

        //********************************
        //Properties
        //********************************
        public string ItemId
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Pack
        {
            get { return _pack; }
            set { _pack = value; }
        }

        //********************************
        //Public Methods
        //********************************
        public override string ToString()
        {
            return _id + ", " + _description + ", " + _pack;
        }

        //********************************
        //Constructors
        //********************************
        public WineItem()
        {
            //Default Blank Constructor
        }

        public WineItem(string ItemId, string Description, string Pack)
        {
            _id = ItemId;
            _description = Description;
            _pack = Pack;
        }
    }
}
