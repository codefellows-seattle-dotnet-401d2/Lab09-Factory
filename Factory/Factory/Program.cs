using System;
using Factory;
using Creator;

namespace ResumeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Factory Design Pattern\n");

            Resume myClassic = new Resume();

            Console.WriteLine("Classic Resume:\n");
            foreach (Page page in myClassic.Pages)
            {
                page.Print();
            }

            Console.ReadLine();
        }
    }
}