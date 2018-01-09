using System;

namespace Factory
{
    public abstract class Page
    {
        public string Author { get; set; } = "DRE";

        public DateTime DateModified { get; set; } = DateTime.Today;
        public DateTime DateCreated { get; set; } = DateTime.Today;
        
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
