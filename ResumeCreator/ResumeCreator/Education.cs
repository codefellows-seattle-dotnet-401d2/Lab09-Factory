using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Education : Page
    {
        public string SchoolName { get; set; } 
        public string DegreeLevel { get; set; } 
        public DateTime GraduationDate { get; set; } 
        public string Major { get; set; }
        public string Minor { get; set; }
    }
}
