using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public class Resume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(Profile);
            Pages.Add(WorkHistory);
            Pages.Add(Education);
        }
    }
}
