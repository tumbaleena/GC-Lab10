using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber10
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList movies = new ArrayList()
            ;
            string category, cont = "y";
#region  // Movie List 
            Movie Movie1 = new Movie("A Bug's Life", "animated", "1");
            movies.Add(Movie1);
            Movie Movie2 = new Movie("Meet the Robinsons", "animated", "1");
            movies.Add(Movie2);
            Movie Movie3 = new Movie("Grandma's Boy", "comedy", "2");
            movies.Add(Movie3);
            Movie Movie4 = new Movie("Mad Max", "action", "3");
            movies.Add(Movie4);
            Movie Movie5 = new Movie("Young Frankenstein", "comedy", "2");
            movies.Add(Movie5);
            Movie Movie6 = new Movie("Iron Man", "action", "3");
            movies.Add(Movie6);
            Movie Movie7 = new Movie("James and the Giant Peach", "animated", "1");
            movies.Add(Movie7);
            Movie Movie8 = new Movie("Ace Ventura: Pet Detective", "comedy", "2");
            movies.Add(Movie8);
            Movie Movie9 = new Movie("Con Air", "action", "3");
            movies.Add(Movie9);
            Movie Movie10 = new Movie("Wreck-It Ralph", "animated", "1");
            movies.Add(Movie10);
            #endregion
            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine("There are 100 movies in this list from the following categories: \n 1. Animated, \n 2. Comedy, \n 3. Action.");
            Console.Write("What category are you interested in? ");
            category = Console.ReadLine().ToLower();

            category = ValidateCategory(category);

            ProcessCategory(cont, movies, category);
        }

        private static void ProcessCategory(string cont, ArrayList movies, string category)
        {
            string input;
            while (cont == "y")
            {
                foreach (Movie movie in movies)
                {
                    if (movie.getCategory() == category)
                    {
                        Console.WriteLine(movie.getTitle());
                    }
                }

                Console.WriteLine();
                Console.Write("Continue? (y/n) ");
                input = Console.ReadLine().ToLower();
                cont = input.Substring(0);
                if (cont == "n")
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();
                Console.Write("What category are you interested in? ");
                category = Console.ReadLine().ToLower();
            }
        }

        private static string ValidateCategory(string category)
        {
            switch (category)
            {
                case "animated":
                    break;
                case "comedy":
                    break;
                case "action":
                    break;
                default:
                    Console.Write("Invalid selection, try again: ");
                    category = Console.ReadLine().ToLower();
                    break;
            }
            return category;
        }
    }
    }