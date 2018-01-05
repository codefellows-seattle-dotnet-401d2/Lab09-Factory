using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    class Resume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new WorkHistory());
            Pages.Add(new Profile());
            Pages.Add(new Projects());
            Pages.Add(new TechnicalSkills());
            Pages.Add(new Education());
        }
    }
}
