using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Blockbuster_movie_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            while (goOn)
            {

                int movieChoice = 10;
                Movie userMovie;

                Console.WriteLine("Would you like to watch scenes from a movie or a whole movie? Choose scenes or movie");
                string input = Console.ReadLine().ToLower().Trim();
                if (input == "scenes")
                {
                    Blockbuster.CheckOut();
                }
                else if (input == "movie")
                {
                    bool askAgain = true;
                    while (askAgain)
                    {
                        Blockbuster.PrintMovies();
                        Console.WriteLine();

                        try
                        {
                            Console.WriteLine("What movie would you like to see? Please enter an index number");
                            movieChoice = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            //Console.WriteLine("This is not a number try again.");
                        }
                        if (movieChoice < Blockbuster.Movies.Count)
                        {
                            userMovie = Blockbuster.Movies[movieChoice];
                            userMovie.PlayWholeMovie();
                            askAgain = false;

                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again");
                            askAgain = true;
                        }
                    }
                }

                Console.WriteLine("Do you want to watch another movie? y or n");
                string another = Console.ReadLine().ToLower().Trim();
                if (another == "y")
                {
                    goOn = true;
                }
                else if (another == "n")
                {
                    Console.WriteLine("Goodbye");
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Returning to main menu");
                    goOn = true;
                }
            }
        }
    }
}
