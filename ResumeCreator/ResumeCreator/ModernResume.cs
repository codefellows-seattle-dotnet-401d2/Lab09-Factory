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
            Pages.Add(new Summary(1));
            Pages.Add(new WorkHistory(2));
            Pages.Add(new Education(3));
        }
    }
}
