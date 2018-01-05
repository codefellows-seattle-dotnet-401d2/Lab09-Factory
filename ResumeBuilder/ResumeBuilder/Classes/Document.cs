using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public abstract class Document
    {
        // List of Pages
        private List<Page> _pages = new List<Page>();

        public List<Page> Pages => _pages;

        public void AddPage(Page page)
        {
            _pages.Add(page);
        }

        // Factory Method
        public abstract void CreatePage();

        public Document ResumeFactory(PageType pageType)
        {
            switch (pageType)
            {
                case PageType.TraditionalResume:
                   return new TraditionalResume();
                case PageType.LargeResume:
                    return new LargeResume();
                case PageType.JustAResume:
                    return new JustAResume();
                default:
                    return null;
            }
        }
    }
}
