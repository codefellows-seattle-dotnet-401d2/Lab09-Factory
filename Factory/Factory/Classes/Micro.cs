using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Classes
{
    /// <summary>
    /// Concrete Creator
    /// </summary>
    public class Micro : Document
    {
        public override void CreateResume()
        {
            Pages.Add(new CoverLetter());
            Pages.Add(new WorkHistory());
            Pages.Add(new References());
        }
    }
}


