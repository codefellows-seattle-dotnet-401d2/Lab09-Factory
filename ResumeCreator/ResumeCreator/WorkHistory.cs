using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class WorkHistory : Page
    {
        public string CompanyName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobTitle { get; set; }
        private List<string> jobDuties = new List<string>();
        public List<string> JobDuties { get => jobDuties; set => jobDuties = value; }
    }
}
