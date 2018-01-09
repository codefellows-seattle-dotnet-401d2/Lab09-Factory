using System.Collections.Generic;
using Factory;

namespace Creator
{
    public abstract class Document
    {
        private List<Page> _pages = new List<Page>();

        public List<Page> Pages
        {
            get { return _pages; }
        }

        public Document()
        {
            CreatePages();
        }

        
        public abstract void CreatePages();
    }
}
