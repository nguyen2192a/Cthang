using System;
using System.Collections.Generic;
using System.Text;

namespace MotobikeStore
{
    class OldMotobike : Motobike
    {
        public override string Type
        {
            get
            {
                return "Old motobike";
            }
            set { }
        }

        public override int Warranty
        {
            get
            {
                return 30;
            }
            set{}
        }
    }
}
