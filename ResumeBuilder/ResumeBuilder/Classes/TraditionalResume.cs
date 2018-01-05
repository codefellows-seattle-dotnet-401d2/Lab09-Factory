using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public class TraditionalResume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new Profile());
            Pages.Add(new WorkHistory());
            Pages.Add(new Education());
        }
    }
}
