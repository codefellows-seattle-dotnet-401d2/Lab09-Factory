using Factory.Classes;
using System;

// complete resumes

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RESUME BUILDER W/ FACTORY METHOD");

            Console.WriteLine("Resume #1");
            var microsoftResume = new Micro();
            Console.WriteLine();
            Console.WriteLine("Resume #2");
            var alaskaAirlinesResume = new Resume();

            Console.ReadLine();
        }

    }
}

