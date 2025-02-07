using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Kalender
    {
		private DateTime _date;

		public DateTime Date
		{
			get { return _date; }
			set { _date = value; }
		}

		private DateTime _time;

		public  DateTime Time 
		{
			get { return _time; }
			set { _time = value; }
		}



	}
}
