using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    internal class Menu
    {
        private List<Item> _menuItems;
        private List<Enhancment> _enhancments;

        public List<Item> MenuItems
        {
            get { return _menuItems; }
        }
        public List<Enhancment> Enhancments
        {
            
            get { return _enhancments; }
        }


}
