using System.Linq.Expressions;

namespace Meethod_excercizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * kirjuta programm mis
             * küsib kasutajalt tema lemmikfilme, küsimine ise on meetodiga, meetodi tulemus tagastatakse muutujasse
             * küsib kasutajalt pealse seda tema lemmikfilmi, vastus hoitakse muutujas
             * programm kontrollib meetodiga, kas lemmikfilm asub kasutaja poolt sisestatud filmide hulgas
             * kui ei ole, siis küsitakse, kus sinu lemmikfilm?
             * kui on siis öeldakse Näe mäletasid ikka!
             * programm küsib kasutajalt kas talle meeldib film X (programmeerija otsustab)
             * Kui jah siis, lisatakse film järjendisse
             * kui ei vingub programm vastu "aga see on ju hea film?"
             * on olemas kindlate filmide tuvastusmeetod, mis otsib, kas järjendis on "Terminator", "Vanamehe Film" või "Kratt"
             * Erinevate filmide kohta esitab meetod erineva sõnumi
             *Terminaatori kohta "Ill be back"
             *Vanamehe Filmi kohta "šnikurs"
             *Krati kohta "Vaata et ta sul tehisplära ajama ei hakka"
             */


            List<string> movies = GetMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("milline on sinu lemmikfilm??");
            string lemmikfilm = Console.ReadLine();
            DoesFavouriteMovieExists(lemmikfilm, movies);
            Console.WriteLine("Aga kas sulle meeldiks äkki Oceans eleven");
            string lisaFilm = Console.ReadLine();
            if (lisaFilm == "jah")
            {
                movies.Add("Oceans Eleven");
            }
            else
            {
                Console.WriteLine("Aga miks, see on ju hea film");
            }

            string messages = FindFilms(movies);
            Console.WriteLine(messages);
        }

        private static string FindFilms(List<string> movies)
        {
            string foundmovies = "";
            foreach (var movie in movies)
            {
                if (movie == "Terminator")
                {
                    foundmovies += "I WILL BE BACK. \n";
                }
                if (movie == "Vanamehe Film")
                {
                    foundmovies += "shmikers!\n";
                }
                if (movie == "Kratt\n")
                {
                    foundmovies += "Vaata et tehisplära ajama eri hakka...";
                }
            }
            return foundmovies;
        }

        private static void DoesFavouriteMovieExists(string? lemmikfilm, List<string> movies)
        {
            bool doesITExistINList = false;
            for (int i = 0; i < movies.Count; i++)
            {
                if (lemmikfilm == movies[i])
                {
                    doesITExistINList = true;
                    break;
                }
            }

            if (doesITExistINList)
            {
                Console.WriteLine("Näe mäletasid ikka!");
            }
            else
            {
                Console.WriteLine("Aga kus sinu lemmikfilm");
            }
        }

        private static List<string> GetMovies()
        {
            var movies = new List<string>();
            string sisestus = "";
            while (sisestus != "ei ole")
            {
                Console.WriteLine("Palun sisesta järgmine film, kui rohkem ei ole, siis kirjuta \"ei ole\"");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    movies.Add(sisestus);

                }
            }
            return movies;
        }
    }
}
