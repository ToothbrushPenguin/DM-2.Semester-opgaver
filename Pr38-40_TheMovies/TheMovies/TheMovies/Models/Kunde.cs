using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Kunde
    {
        private int _phoneNumber; 

        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
