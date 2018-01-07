using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public abstract class Document
    {
        public Profile Profile { get; set; }
        public TechnicalSkills TechnicalSkills { get; set; }
        public Projects Projects { get; set; }
        public WorkHistory WorkHistory { get; set; }
        public Education Education { get; set; }

        // List of Pages
        public List<Page> Pages = new List<Page>();

        // Factory Method
        public abstract void CreatePage();

        // Resume factory for the user to pick
        public Document ResumeFactory(PageType pageType)
        {
            switch (pageType)
            {
                case PageType.TraditionalResume:
                   return new Resume();
                case PageType.LargeResume:
                    return new Portfolio();
                default:
                    return null;
            }
        }
    }
}
