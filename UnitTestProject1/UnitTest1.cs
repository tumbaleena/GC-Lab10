using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Movie Movie1 = new Movie("A Bug's Life", "animated", "1");
            movies.Add(Movie1);
            Movie1.GetTitle();
            Movie Movie2 = new Movie("Meet the Robinsons", "animated", "1");
            movies.Add(Movie2);
            Movie2.GetTitle();
            Movie Movie3 = new Movie("Grandma's Boy", "comedy", "2");
            movies.Add(Movie3);
            Movie3.GetTitle();
            Movie Movie4 = new Movie("Mad Max", "action", "3");
            movies.Add(Movie4);
            Movie4.GetTitle();
            Movie Movie5 = new Movie("Young Frankenstein", "comedy", "2");
            movies.Add(Movie5);
            Movie5.GetTitle();
            Movie Movie6 = new Movie("Iron Man", "action", "3");
            movies.Add(Movie6);
            Movie6.GetTitle();
            Movie Movie7 = new Movie("James and the Giant Peach", "animated", "1");
            movies.Add(Movie7);
            Movie7.GetTitle();
            Movie Movie8 = new Movie("Ace Ventura: Pet Detective", "comedy", "2");
            movies.Add(Movie8);
            Movie8.GetTitle();
            Movie Movie9 = new Movie("Con Air", "action", "3");
            movies.Add(Movie9);
            Movie9.GetTitle();
            Movie Movie10 = new Movie("Wreck-It Ralph", "animated", "1");
            movies.Add(Movie10);
            Movie10.GetTitle();
        }
    }
}
