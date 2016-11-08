using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabNumber10;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ArrayList movies = new ArrayList();
            string category, input, cont = "y";
            Movie Movie1 = new Movie("A Bug's Life", "animated", "1");
            movies.Add(Movie1);
            Movie1.getTitle();
            Movie Movie2 = new Movie("Meet the Robinsons", "animated", "1");
            movies.Add(Movie2);
            Movie2.getTitle();
            Movie Movie3 = new Movie("Grandma's Boy", "comedy", "2");
            movies.Add(Movie3);
            Movie3.getTitle();
            Movie Movie4 = new Movie("Mad Max", "action", "3");
            movies.Add(Movie4);
            Movie4.getTitle();
            Movie Movie5 = new Movie("Young Frankenstein", "comedy", "2");
            movies.Add(Movie5);
            Movie5.getTitle();
            Movie Movie6 = new Movie("Iron Man", "action", "3");
            movies.Add(Movie6);
            Movie6.getTitle();
            Movie Movie7 = new Movie("James and the Giant Peach", "animated", "1");
            movies.Add(Movie7);
            Movie7.getTitle();
            Movie Movie8 = new Movie("Ace Ventura: Pet Detective", "comedy", "2");
            movies.Add(Movie8);
            Movie8.getTitle();
            Movie Movie9 = new Movie("Con Air", "action", "3");
            movies.Add(Movie9);
            Movie9.getTitle();
            Movie Movie10 = new Movie("Wreck-It Ralph", "animated", "1");
            movies.Add(Movie10);
            Movie10.getTitle();

            foreach (Movie movie in movies)
            { Console.WriteLine(movie); }
        }
        
    }
}
