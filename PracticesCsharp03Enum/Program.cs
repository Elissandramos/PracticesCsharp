using System;
using System.Globalization;
using System.Text;
using PracticesCsharp03Enum.Entities03;

namespace PracticesCsharp03Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initiate classes first post

            Comment c1 = new Comment("Have a nice trip");

            Comment c2 = new Comment("Wow! tha's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2017 13:05:44"),
                "Traveling to new Zeland",
                "I'm going to visit this wonderfull country!",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);

            //instantiate and initiate classes first post

            Comment c3 = new Comment("Good Night");

            Comment c4 = new Comment("May the force be with you");

            Post p2 = new Post(
                DateTime.Parse("25/06/2017 13:05:44"),
                "Good Night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            //print the objects, but now as a string because it was used ToString+Stringbuilder in their classes

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
                
    }
}