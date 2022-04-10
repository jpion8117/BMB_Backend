using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    internal class Order
    {
        private List<Item> _orderItems = new List<Item>();
        private double _subTotal;
        private double _tax;
        private double _total;

        public Order()
        {
            _subTotal = 0;
            _tax = 0;
            _total = 0;
        }

        public double Tax
        {
            get { return _tax; }
        }
        public double Total
        {
            get { return _total; }
        }
        public double SubTotal
        {
            get { return _subTotal; }
            private set 
            { 
                _subTotal = value;
                _tax = _subTotal * 0.06;
                _total = _subTotal + _tax;
            }
        }

        public void addToOrder(Item newItem)
        {
            //add item to the orderItems Array
            _orderItems.Add(newItem);

            //add price to the sub total (tax and total are figured out automatically)
            SubTotal += newItem.Price;
        }

        public string[] getOrderDetails()
        {
            //create a container to hold the string array
            List<string> details = new List<string>();

            //itterate through all items in the cart
            for (int i = 0; i < _orderItems.Count; i++)
            {
                //get the item info from item at index i then extract each output line
                for (int j = 0; j < _orderItems[i].getItemInfo().Length; j++)
                {
                    //add each output line to the container
                    details.Add(_orderItems[i].getItemInfo()[j]);
                }
            }

            //return the container as a string
            return details.ToArray();
        }
    }
}
