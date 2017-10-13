using System;
using System.Collections.Generic;
using System.Text;

namespace MotobikeStore
{
    class BuyMotobikeCustomer
    {
        #region Fields
        private string name;
        private string address;
        private string phone;
        private string email;
        private Motobike buyMotobike;
        #endregion

        #region Propertises
        public Motobike BuyMotobike
        {
            get { return buyMotobike; }
            set { buyMotobike = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
    }
}
