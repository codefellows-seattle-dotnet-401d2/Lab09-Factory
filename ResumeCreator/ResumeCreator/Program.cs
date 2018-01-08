using System;
using Product;
using Creator;

namespace ResumeCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing Factory Design Pattern\n");

            ClassicResume myClassic = new ClassicResume();
            ModernResume myModern = new ModernResume();

            Console.WriteLine("Classic Resume:\n");
            foreach (Page page in myClassic.Pages)
            {
                page.Print();
            }

            Console.WriteLine("Modern Resume:\n");
            foreach (Page page in myModern.Pages)
            {
                page.Print();
            }

            Console.ReadLine();
        }
    }
}
