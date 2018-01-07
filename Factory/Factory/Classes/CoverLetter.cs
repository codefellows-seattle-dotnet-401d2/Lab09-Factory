using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CoverLetter : Pages
    {
        public CoverLetter()
        {
            Console.WriteLine("Cover Letter for Microsoft");
        }
    }
}

