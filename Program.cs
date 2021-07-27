using System;

namespace getterSetterSHIT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Movie shrek = new Movie("Shrek", "PG-13", 160);
            //Console.WriteLine(shrek.Rating);
            Console.WriteLine("Whats your movie title?");
            var movieTitle = Console.ReadLine();

            Console.WriteLine("Whats your movie rating?");
            var movieRating = Console.ReadLine();

            Console.WriteLine("Whats your movie in seconds?");
            var movieSeconds = Console.ReadLine();
            
            Movie testMovie = new Movie(movieTitle, movieRating, (int)double.Parse(movieSeconds));
            Console.WriteLine(testMovie.Title + " " + testMovie.Rating + " " + testMovie.seconds);

        }
    }
}
