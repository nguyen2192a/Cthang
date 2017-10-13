using System;
using System.Collections.Generic;
using System.Text;

namespace MotobikeStore
{
    class MotobikeAgent
    {
        List<BuyMotobikeCustomer> motobikeList;

        internal List<BuyMotobikeCustomer> MotobikeList
        {
            get { return motobikeList; }
            set { motobikeList = value; }
        }

        public MotobikeAgent()
        {
            motobikeList = new List<BuyMotobikeCustomer>() ;
        }

        public BuyMotobikeCustomer this[int i]
        {
            get
            {
                return MotobikeList[i];
            }

            set
            {
                MotobikeList[i] = value;
            }
        }

        public void Add(BuyMotobikeCustomer buymotobike)
        {
            MotobikeList.Add(buymotobike);
        }

        public int GetCount()
        {
            return MotobikeList.Count;
        }
        
    }
}
