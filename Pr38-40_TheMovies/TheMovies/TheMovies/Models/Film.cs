using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class Film
    {
        private static int idCount = 0;
        private string title;
        public string Title { get { return title; } }
        private TimeSpan runTime;
        public TimeSpan RunTime { get { return runTime; } set { runTime = value; } }
        private string director;
        public string Director { get { return director; } }
        private double price;
        public double Price { get { return price; } set { Price = value; } }
        private int ageRestriction;
        public int AgeRestriction { get { return ageRestriction; } }
        private string genre;
        public string Genre { get { return genre; } }


        public Film(string title, TimeSpan runtime, string director, double price, int agerestriction, string genre)
        {
            idCount++;
            this.title = title;
            RunTime = runtime;
            this.director = director;
            Price = price;
            this.ageRestriction = agerestriction;
            this.genre = genre;
        }
    }
}
