using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    public class Transaction
    {
        private int code;
        private int transactiontype;
        private DateTime transactiondate;
        private double total;
        private Account acc;
        public int Code
        {
            get; set;
        }
        public int Transactiontype
        {
            get; set;
        }
        public DateTime Transactiondate
        {
            get
            {
                return transactiondate;
            }

            set
            {
                if ((value - DateTime.Now).Days > 0)
                {
                    throw new Exception("Ngay dong khong o qua khu");
                }
                else
                {
                    transactiondate = value;
                }
            }
        }
        public double Total
        {
            get; set;
        }
        public Account Acc
        {
            get;set;
        }
    }
}
