using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public abstract class Page
    {
        public string Color { get; set; }
        public bool Lined { get; set; }
        public Profile Profile { get; set; }
        public TechnicalSkills TechnicalSkills { get; set; }
        public Projects Projects { get; set; }
        public WorkHistory WorkHistory { get; set; }
        public Education Education { get; set; }
    }
}
