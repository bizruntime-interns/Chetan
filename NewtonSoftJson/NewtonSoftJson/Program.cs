using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoftJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Serialization");
            Movie movie = new Movie { Id = 1, Title = "Mission Impossible" };
            string result=JsonConvert.SerializeObject(movie);
            Console.WriteLine(result);

            Console.WriteLine("Deserialization");
            Movie item = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine($"Id:{item.Id} Title:{item.Title}");

            // Using Collections
            List<Movie> movies = new List<Movie>
            {
                new Movie{Id=1,Title="Titanic"},
                new Movie{Id=2,Title="Black Phanter"},
                new Movie{Id=3,Title="Spiderman"},
                new Movie{Id=4,Title="Fast and Furious"},
                new Movie{Id=5,Title="Need for Speed"},
            };

            string collectionResult=JsonConvert.SerializeObject(movies);
            Console.WriteLine(collectionResult);

            List<Movie> newMovies = JsonConvert.DeserializeObject<List<Movie>>(collectionResult);
            foreach (Movie i in newMovies)
            {
                Console.WriteLine($"Id:{i.Id} Title:{i.Title}");
            }
        }
    }
}
