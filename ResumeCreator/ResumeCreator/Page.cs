using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public abstract class Page
    {
        public string Size { get; set; }
        public string Style { get; set; }
        public string Weight { get; set; }

        public void Print()
        {
            Console.WriteLine("Printing page.");
        }

        public void Save()
        {
            Console.WriteLine("Saving page.");
        }

        public void Copy()
        {
            Console.WriteLine("Copying page.");
        }
    }
}
