using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public abstract class Page
    {
        public string Author { get; set; } = "Ariel Pedraza";
        public DateTime DateCreated { get; set; } = DateTime.Today;
        public DateTime DateModified { get; set; } = DateTime.Today;
        public int PageNum { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("Printing page....");
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
