using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMovies.Models
{
    public class FilmRepository
    {
        private List<Film> Films = new List<Film>();

        public Film Create(string title, TimeSpan runtime, string director, double price, int agerestrictions, string genre)
        {
            Film newFilm = new Film(title,runtime,director,price,agerestrictions,genre);
            Films.Add(newFilm);
            return newFilm;
        }

        public Film Read(int id)
        {

        }

        public Film Update(int id, string title, TimeSpan runtime, string director, double price, int agerestrictions, string genre)
        {

        }

        public void Delete(int id) 
        {
            
        }

    }
}
