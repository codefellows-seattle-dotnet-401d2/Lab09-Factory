using System;
using System.Collections.Generic;

namespace Factory
{
    public class References : Page
    {
        private List<string> contactInfo = new List<string>();
        public List<string> ContactInfo { get => contactInfo; set => contactInfo = value; }

        public References(int pageNum)
        {
            PageNum = pageNum;
            ContactInfo.Add("The Donald, AKA 45th POTUS");
        }

        public override void Print()
        {
            Console.WriteLine($"----- References: Page {PageNum} -----");
            foreach (string contacts in ContactInfo) Console.WriteLine("- " + contacts);
            Console.WriteLine("");
        }
    }
}