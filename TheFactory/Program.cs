using System;

namespace TheFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TheFactory SCP Documentation Generator.");
            Console.WriteLine("Please enter your full name as you wish it to appear on any documents you create.");
            string user = Console.ReadLine();
            // type TheFactory is the same as the namespace so Concrete.TheFactory avoids problems.
            Concretes.TheFactory ScipMaker = new Concretes.TheFactory(user);
            Console.Clear();

            Console.WriteLine("Username excepted. Welcome Doctor/Researcher/Agent " + user + ".");
            Console.WriteLine("Press enter to generate a document.");
            Console.Read();
            Console.Clear();
            BeginDocumentCreator(ScipMaker);
        }

        static void BeginDocumentCreator( Concretes.TheFactory factory)
        {
            Console.WriteLine("What is the title of your SCP? This can be something like \"The Boogyman\".");
            string title = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please specify Containment Proceedures.");
            string scproceedures = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter a description.");
            string description = Console.ReadLine();
            Console.Clear();

            factory.PrintSCP(title, scproceedures, description);

            Console.WriteLine("Do you want to generate another document?.");
            string answer = Console.ReadLine();
            Console.Clear();
            if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes")
            {
                BeginDocumentCreator();
            }
            else
            {
                Console.Write("Thank you for using TheFactory Document Generator. Have a safe day.");
                Console.Read();
                Console.Clear();
                Console.Read();
            }

        }
    }
}
