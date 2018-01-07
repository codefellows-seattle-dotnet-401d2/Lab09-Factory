using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public class Education : Page
    {
        public string SchoolName { get; set; }
        public string Course { get; set; }
        public int GraduationMonth { get; set; }
        public int GraduationYear { get; set; }
    }
}
