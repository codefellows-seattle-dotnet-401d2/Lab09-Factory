using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class CoverLetter : Page
    {
        public string AddressedTo { get; set; } = "Microsoft";
        public string BodyText { get; set; } = "You should hire me because I know dank memes.";
        public string Signature { get; set; } = "Ariel Pedraza - .NET Full Stack Web Dev";

        public CoverLetter(int pageNum)
        {
            PageNum = pageNum;
        }

        public override void Print()
        {
            Console.WriteLine($"----- Cover Letter: Page {PageNum} -----");
            Console.WriteLine("Dear: " + AddressedTo);
            Console.WriteLine(BodyText);
            Console.WriteLine("Very Respectfully, " + Signature);
            Console.WriteLine("");
        }
    }
}
