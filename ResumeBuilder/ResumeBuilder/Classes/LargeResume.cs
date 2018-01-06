using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public class LargeResume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(Profile);
            Pages.Add(TechnicalSkills);
            Pages.Add(Projects);
            Pages.Add(WorkHistory);
            Pages.Add(Education);
        }
    }
}
