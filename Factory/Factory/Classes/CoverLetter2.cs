using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// Concrete Product
    /// </summary>
    public class CoverLetter2 : Pages
    {
        public CoverLetter2()
        {
            Console.WriteLine("Cover Letter for Alaska Airlines");
        }
    }
}