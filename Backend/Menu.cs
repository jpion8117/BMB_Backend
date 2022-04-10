using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Backend
{
    
    internal class Menu
    {
        //settings filepath
        const string MENU_FILE_PATH = "Menu/menu.bmb";
        
        private List<Item> _menuItems = new List<Item>();
        private List<Enhancment> _enhancments = new List<Enhancment>();

        public List<Item> MenuItems
        {
            get { return _menuItems; }
        }
        public List<Enhancment> Enhancments
        {
            get { return _enhancments; }
        }
        
        public void LoadMenu()
        {

        }

    }
}
