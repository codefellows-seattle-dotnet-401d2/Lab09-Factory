using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class References : Pages
    {
        public References()
        {
            Console.WriteLine();
            Console.WriteLine("References: ");
            Console.WriteLine("Reference: Boss");
            Console.WriteLine("Reference: Professor");
            Console.WriteLine("Reference: Mentor");

        }
    }
}
