using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    /// <summary>
    /// Product
    /// </summary>
    public abstract class Pages
    {
        public int NumberOfPages { get; set; }
        public string PageType { get; set; }

    }
}
