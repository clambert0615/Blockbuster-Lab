using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Blockbuster_movie_lab
{
    class Blockbuster
    {
        public static List<Movie> Movies { get; set; }

        public static void AddMovies()
        {
           Movies = new List<Movie>();

            List<string> vhs1Scenes = new List<string> { "Opening scene", "Johnny Fontane scene", "Horse's head scene" };
            List<string> vhs2Scenes = new List<string> { "Dinner scene", "Arrest scene", "Sinknig scene" };
            List<string> vhs3Scenes = new List<string> { "Hit by a truck scene", "Back from the dead scene", "Undead family scene" };
            List<string> dvd1Scenes = new List<string> { "Immature friends scene", "Morning after scene", "The wrong Doug scene" };
            List<string> dvd2Scenes = new List<string> { "Surfboard stakeout scene", "Undercover nuns scene", "Last dance scene" };
            List<string> dvd3Scenes = new List<string> { "Urine trouble scene", "Atomic peppers scene", "Two lucky guys scene" };

            VHS vhs1 = new VHS("The Godfather", Movie.Genre.Drama, 110, vhs1Scenes);
            VHS vhs2 = new VHS("Titanic", Movie.Genre.Romance, 195, vhs2Scenes);
            VHS vhs3 = new VHS("Pet Semetary", Movie.Genre.Horror, 100, vhs3Scenes);
            DVD dvd1 = new DVD("The Hangover", Movie.Genre.Comedy, 108, dvd1Scenes);
            DVD dvd2 = new DVD("Charlie's Angels", Movie.Genre.Action, 118, dvd2Scenes);
            DVD dvd3 = new DVD("Dumb and Dumber", Movie.Genre.Comedy, 113, dvd3Scenes);

            Movies.Add(vhs1);
            Movies.Add(vhs2);
            Movies.Add(vhs3);
            Movies.Add(dvd1);
            Movies.Add(dvd2);
            Movies.Add(dvd3);

        }

        public static void PrintMovies()
        {
            int index = 0;

            AddMovies();

            foreach(Movie m in Movies)
            {
                Console.WriteLine($"{index} : {m.PrintInfo()}");
                index++;
            }

        }

        public static void CheckOut()
        {
            bool goOn = true;
            while (goOn)
            {
                Movie userMovie;
                int movieChoice = 10;

                PrintMovies();
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
                if (movieChoice < Movies.Count)
                {
                    userMovie = Movies[movieChoice];
                   Console.WriteLine( userMovie.PrintInfo());
                    
                }
                else
                {
                    Console.WriteLine("Movie not found.  Please enter a valid number in the list.");
                    continue;
                }

                Console.WriteLine("Do you want to watch the movie? y or n");
                string decision = Console.ReadLine().ToLower().Trim();
                if(decision == "y")
                {
                    Console.WriteLine();
                    userMovie.Play();
                    Console.WriteLine();

                    bool keepPlaying = true;
                    while (keepPlaying)
                    {
                        Console.WriteLine("Do you want to watch another scene?");
                        string sceneDecision = Console.ReadLine().ToLower().Trim();
                        if (sceneDecision == "y")
                        {
                            userMovie.Play();
                        }
                        else if (sceneDecision == "n")
                        {
                            Console.WriteLine("Returning to main menu.");
                            keepPlaying = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Try again");
                            keepPlaying = true;
                        }
                    }
                }
                else if (decision == "n")
                {
                    Console.WriteLine("Returning to menu");
                    goOn = false;
                }
                else
                {
                    Console.WriteLine("Invalid input.  Try again");
                    goOn = true;
                }
               
            }
        }
    }
}