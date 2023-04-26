﻿using Microsoft.AspNetCore.Mvc;

namespace modul9_1302210022.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public static List<string> Stars1 = new List<string>()
        {
            "Tim Robbins",
            "Morgan Freeman",
            "Bob Gunton",
            "William Sadler",
        };

        public static List<string> Stars2 = new List<string>()
        {
            "Marlon Brando",
            "Al Pacino",
            "James Caan",
            "Diane Keaton",
        };

        public static List<string> Stars3 = new List<string>()
        {
            "Christian Bale",
            "Heath Ledger",
            "Aaron Eckhart",
            "Michael Caine",
        };

        public static List<Movie> dataMovie = new List<Movie>()
        {
            
            new Movie("The Shawshank Redemption","Frank Darabont", Stars1, "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."),
            new Movie("The Godfather", "Francis Ford Coppola", Stars2, "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."),
            new Movie("The Dark Knight", "Christopher Nolan", Stars3, "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.")
        };

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return dataMovie;
        }

        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return dataMovie[id];
        }

        [HttpPost]
        public void Post(Movie movie)
        {
            dataMovie.Add(movie);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMovie.RemoveAt(id);
        }
    }
}
