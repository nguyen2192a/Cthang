using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
   class WaterAccount : Account
    {
        public WaterAccount() { }

        public override string Type
        {
            get
            {
                return "Water";

            }
        }
    }
}
