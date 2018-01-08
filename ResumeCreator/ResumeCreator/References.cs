using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class References : Page
    {
        private List<string> contactInfo = new List<string>();
        public List<string> ContactInfo { get => contactInfo; set => contactInfo = value; }

        public References(int pageNum)
        {
            PageNum = pageNum;
            ContactInfo.Add("Andrea - Manager - v-anfrab@microsoft.com");
        }

        public override void Print()
        {
            Console.WriteLine($"----- References: Page {PageNum} -----");
            foreach (string contacts in ContactInfo) Console.WriteLine("- " + contacts);
            Console.WriteLine("");
        }
    }
}
