using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    class WorkHistory : Pages
    {
        public WorkHistory()
        {
            Console.WriteLine();
            Console.WriteLine("Work History: ");
            Console.WriteLine("Work Location 1");
            Console.WriteLine("Work Location 2");
            Console.WriteLine("Work Location 3");
        }
    }
}
