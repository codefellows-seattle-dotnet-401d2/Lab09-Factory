using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    /// <summary>
    /// Creator
    /// </summary>
    public abstract class Document
    {
           private List<Pages> pages = new List<Pages>();

            public Document()
            {
                CreateResume();
            }

            //Factory method
            public abstract void CreateResume();

            public List<Pages> Pages
            {
                get { return pages; }
            }
    }
}

