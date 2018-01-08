using System;
using Product;
using Creator;

namespace ResumeCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ClassicResume myClassic = new ClassicResume();
            ModernResume myModern = new ModernResume();

            foreach (Page page in myClassic.Pages)
            {
                page.Print();
            }

            foreach(Page page in myModern.Pages)
            {
                page.Print();
            }

            Console.ReadLine();
        }
    }
}
