using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMovies.Models;

namespace TheMovies.Persistance
{
    public class FilmRepository
    {
        private List<Film> films = new List<Film>();

        public void Create(string title, TimeSpan runtime, string director, double price, int agerestriction, string genre)
        {
            films.Add(new Film(title, runtime, director, price, agerestriction, genre));
        }

        public void Read()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}
