using System;
using System.Collections.Generic;
using System.Text;

namespace MotobikeStore
{
    public abstract class Motobike
    {
        #region Fields
        private string code;
        private string name;
        private double price;
        private DateTime saleDate;
        //private string type;
        //private int warranty;
        #endregion

        #region non_abstract_Propertises
        public DateTime SaleDate
        {
            get { return saleDate; }
            set 
            {
                if ((value - DateTime.Now).Days > 0)
                {
                    throw new Exception("Sale day does not in future");
                }
                else
                {
                    saleDate = value;
                }
            }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public int WarrantyRemain
        {
            get
            {
                DateTime wd = SaleDate.AddDays(Warranty);
                return (wd - DateTime.Now).Days;
            }
        }
        #endregion

        #region abstract_Propertises
        public abstract int Warranty
        {
            get;
            set;
        }
        public abstract string Type
        {
            get;
            set;
        }
        #endregion
    }
}
