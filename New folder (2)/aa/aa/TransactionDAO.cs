using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
    class TransactionDAO
    {
        List<Transaction> list = null;

        public TransactionDAO()
        {
            list = new List<Transaction>();
        }
        public Transaction Create(Transaction t)
        {
            list.Add(t);
            return t;
        }
        public List<Transaction> ReadAll()
        {
            return list;
        }
        public Transaction SearchByCode(int code)
        {
            foreach(Transaction t in list){
                if(t.Code == code)
                {
                    return t;
                }
            }
            return null;
        }
    }
}
