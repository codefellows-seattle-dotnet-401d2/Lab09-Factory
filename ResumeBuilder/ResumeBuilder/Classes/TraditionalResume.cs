using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    class TraditionalResume : Document
    {
        public override void CreatePage(Profile p, WorkHistory w, Education e)
        {
            Pages.Add(p);
            Pages.Add(w);
            Pages.Add(e);
        }
    }
}
