using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Education : Page
    {
        public string SchoolName { get; set; } = "University of Scranton";
        public string DegreeLevel { get; set; } = "Bachelor of Science";
        public DateTime GraduationDate { get; set; } = new DateTime(2008, 12, 15);
        public string Major { get; set; } = "Computer Information Systems";
        public string Minor { get; set; } = "";

        public Education(int pageNum)
        {
            PageNum = pageNum;
        }
    }
}
