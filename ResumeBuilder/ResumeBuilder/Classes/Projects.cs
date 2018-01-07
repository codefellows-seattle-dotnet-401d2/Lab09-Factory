using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeBuilder.Classes
{
    public class Projects : Page
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public int TotalMonthsSpent { get; set; }
    }
}
