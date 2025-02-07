using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Reservation
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _phoneNumber;
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        private int _numberOfTickets;
        public int NumberOfTickets
        {
            get { return _numberOfTickets; }
            set { _numberOfTickets = value; }
        }

        private string _location;
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _titel;
        public string Titel
        {
            get { return _titel; }
            set { _titel = value; }
        }
        private DateTime _filmStart;
        public DateTime FilmStart
        {
            get { return _filmStart; }
            set { _filmStart = value; }
        }



    }
}
