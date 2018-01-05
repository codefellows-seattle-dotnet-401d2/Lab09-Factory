using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    class JustAResume : Document
    {
        public override void CreatePage()
        {
            Pages.Add(new Profile());
            Pages.Add(new WorkHistory());
        }
    }
}
