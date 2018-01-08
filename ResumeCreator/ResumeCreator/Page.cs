using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public abstract class Page
    {
        public string Author { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int PageNum { get; set; }

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
