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
        public int Id { get; set;}
        public string Title { get;}
        public TimeSpan RunTime { get; set;}
        public string Director { get;}
        public double Price { get; set;}
        public int AgeRestrictions { get;}
        public string Genre { get;}

        public Film(string title, TimeSpan runTime, string director, double price, int ageRestrictions, string genre)
        {
            Title = title;
            RunTime = runTime;
            Director = director;
            Price = price;
            AgeRestrictions = ageRestrictions;
            Genre = genre;
            Id = idCount++;
        }
    }
}
