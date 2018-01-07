using System;
using System.Collections.Generic;
using System.Text;
using Product;

namespace Creator
{
    public class ClassicResume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new CoverLetter());
            Pages.Add(new WorkHistory());
            Pages.Add(new Education());
            Pages.Add(new References());
        }
    }
}
