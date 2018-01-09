using System;
using System.Collections.Generic;

namespace Factory
{
    public class WorkHistory : Page
    {
        public string CompanyName { get; set; } = "Army";

        public DateTime StartDate { get; set; } = new DateTime(2020, 8, 8);

        public DateTime EndDate { get; set; } = new DateTime(2020, 8, 9);

        public string JobTitle { get; set; } = "Through hard work and dedication became a NBK Natural Born Killer";

        private List<string> jobDuties = new List<string>();

        public List<string> JobDuties { get => jobDuties; set => jobDuties = value; }

        public WorkHistory(int pageNum)
        {
            PageNum = pageNum;
            JobDuties.Add("1. Was awesome at everything");
            JobDuties.Add("2. Got everything done on time");
        }

        public override void Print()
        {
            Console.WriteLine($"----- Work History: Page {PageNum} -----");
            Console.WriteLine(CompanyName + " - " + JobTitle);
            Console.WriteLine(StartDate.ToString() + " - " + EndDate.ToString());
            foreach (string duty in JobDuties) Console.WriteLine("- " + duty);
            Console.WriteLine("");
        }
    }
}
