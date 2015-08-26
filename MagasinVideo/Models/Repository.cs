using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace MagasinVideo.Models
{
    public class Repository
    {
        public List<Movie> GetAllMovies()
        {
            Movie m1 = new Movie
            {
                Id = 1,
                Title = "PulpFiction",
                Genre = "Acion"
            };

            Movie m2 = new Movie
            {
                Id = 2,
                Title = "Alien",
                Genre = "Sci-Fi"
            };
            List<Movie> list = new List<Movie>();
            list.Add(m1);
            list.Add(m2);

            return list;
        }

        public String GetMovie(int seekedId)
        {
            if (seekedId == 1)
            {
                return "PulpFiction";
            }
            else if (seekedId == 2)
            {
                return "Alien";
            }
            else
            {
                return "Error 420";
            }
        }
        public void AddMovie(String titre, String genre)
        {
        

        }

        public void DeleteMovie(int Id)
        {

        }
    }
}