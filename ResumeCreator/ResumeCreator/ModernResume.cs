using System;
using System.Collections.Generic;
using System.Text;
using Product;

namespace Creator
{
    public class ModernResume : Document
    {
        public override void CreatePages()
        {
            Pages.Add(new Summary());
            Pages.Add(new WorkHistory());
            Pages.Add(new Education());
        }
    }
}
