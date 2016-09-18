using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._12___Invoice_Class
{
    class Invoice
    {
        public string partNumber;
        public string partDescription;
        private int _quantity;
        public int quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value >= 0)
                {
                    _quantity = value;
                }
            }
        }
        private decimal _pricePer;
        public decimal pricePer
        {
            get
            {
                return _pricePer;
            }
            set
            {
                if (value >= 0)
                {
                    _pricePer = value;
                }
            }
        }
        public Invoice(string Part_Number, string part_Description, int Quantity, decimal Price_Per_Item)
        {
            if (Quantity < 0)
            {
                throw new ArgumentException("Quantity needs to be >=0");
            }
            if (Price_Per_Item < 0)
            {
                throw new ArgumentException("Price_Per_Item needs to be >=0");
            }
            partNumber = Part_Number;
            partDescription = part_Description;
            _quantity = Quantity;
            _pricePer = Price_Per_Item;
        }
        public decimal GetInvoiceAmount()
        {
            return _pricePer*_quantity;
        }
    }
}
