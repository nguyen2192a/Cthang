﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aa
{
   class ElectronicAccount : Account
    {
        public ElectronicAccount() { }

        public override string Type
        {
            get
            {
                return "Electronic";
            }
        }
    }
}
