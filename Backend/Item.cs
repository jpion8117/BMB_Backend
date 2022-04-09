using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    internal class Item
    {
        private string _name;
        private string _description;
        private string _imageURL;
        private double _price;

        public string[] getItemInfo()
        {
            //create list to hold return array
            List<string> items = new List<string>();

            items.Add(_name);
            items.Add(_description);
            items.Add(_imageURL);
            items.Add()

            //return array
            return items.ToArray();
        }
    }
}
//owo~ //mkvmkvdkl