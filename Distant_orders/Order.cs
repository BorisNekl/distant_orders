using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distant_orders
{
    class Order
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        private string phone;

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private string zip_code;

        public string Zip_code
        {
            get { return zip_code; }
            set { zip_code = value; }
        }

        public Order(string name, string surname, string phone, string mail, string address, string zip_code)
        {
            this.name = name;
            this.surname = surname;
            this.mail = mail;
            this.phone = phone;
            this.address = address;
            this.zip_code = zip_code;
        }

    }
}
