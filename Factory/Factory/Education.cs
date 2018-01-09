using System;

namespace Factory
{
    public class Education : Page
    {
        public string SchoolName { get; set; } = "University of HardKnocks";
        public string DegreeLevel { get; set; } = "Black Belt";
        public DateTime GraduationDate { get; set; } = new DateTime(2020, 8, 8);
        public string Major { get; set; } = "Kicking Ass and Taking Names";

        public Education(int pageNum)
        {
            PageNum = pageNum;
        }

        public override void Print()
        {
            Console.WriteLine($"----- Work History: Page {PageNum} -----");
            Console.WriteLine(SchoolName + " - " + GraduationDate.ToString());
            Console.WriteLine($"My Degree Level is {DegreeLevel}");
            Console.WriteLine("Major: " + Major);
            Console.WriteLine("");
        }
    }
}
