using System;
using System.Collections.Generic;
using System.Text;

namespace MotobikeStore
{
    class NewMotobike : Motobike
    {
        public override string Type
        {
            get
            {
                return "New motobike";
            }
            set{}
        }

        public override int Warranty
        {
            get
            {
                return 365;
            }
            set{}
        }
    }
}
