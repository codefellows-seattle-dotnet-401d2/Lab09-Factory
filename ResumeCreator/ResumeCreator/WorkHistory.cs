using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class WorkHistory : Page
    {
        public string CompanyName { get; set; } = "Microsoft";
        public DateTime StartDate { get; set; } = new DateTime(2017, 4, 15);
        public DateTime EndDate { get; set; } = new DateTime(2017, 9, 15);
        public string JobTitle { get; set; } = "Support Engineer";
        private List<string> jobDuties = new List<string>();
        public List<string> JobDuties { get => jobDuties; set => jobDuties = value; }

        public WorkHistory(int pageNum)
        {
            PageNum = pageNum;
            JobDuties.Add("Troubleshoot customer Microsoft Intune deployments");
            JobDuties.Add("Update service requests");
        }

        public override void Print()
        {
            Console.WriteLine($"----- Work History: Page {PageNum} -----");
            Console.WriteLine(CompanyName + " - " + JobTitle);
            Console.WriteLine(StartDate.ToString() + " - " + EndDate.ToString());
            foreach(string duty in JobDuties) Console.WriteLine("- " + duty);
            Console.WriteLine("");
        }
    }
}
