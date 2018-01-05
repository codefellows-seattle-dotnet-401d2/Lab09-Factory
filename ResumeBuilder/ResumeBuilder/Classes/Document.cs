using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public abstract class Document
    {
        // List of Products:Pages
        private List<Page> _pages = new List<Page>();

        public Document()
        {
            CreatePage();
        }

        // Factory Method
        public abstract void CreatePage();

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public void AddPage(Page page)
        {
            _pages.Add(page);
        }
    }
}
