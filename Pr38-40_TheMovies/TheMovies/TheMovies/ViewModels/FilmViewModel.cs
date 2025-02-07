using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;

namespace TheMovies.ViewModels
{
    public class FilmViewModel
    {
        private Film film;
        public string Title { get;}
        public TimeSpan RunTime { get; set; }
        public string Director { get;}
        public double Price { get; set; }
        public int AgeRestrictions { get;}
        public string Genre { get;}

        public FilmViewModel(Film film) 
        { 
        
        }
    }
}
