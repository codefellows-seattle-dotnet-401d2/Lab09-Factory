using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public class Portfolio : Document
    {
        public override void CreatePage()
        {
            Pages.Add(Projects);
        }
    }
}
