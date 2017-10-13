using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public abstract class Account
    {
        #region Fields
        private int code;
        private int month;
        private string name;
        private string address;
        private double total;
        #endregion

        public int Code
        {
            get; set;
        }
        public int Month
        {
            get;
            set;
        }


        public string Name
        {
            get; set;
        }


        public string Address
        {
            get; set;
        }

        public double Total
        {
            get; set;
        }

        public abstract string Type
        {
            get;
        }
    }

}
