using System;

namespace Factory
{
    public class CoverLetter : Page
    {
        public string AddressedTo { get; set; } = "Dream Job";
        public string BodyText { get; set; } = "Someone PLEASE just give me an entry level job were I make 60Gs take home.";
        public string Signature { get; set; } = "Drizzy Dre";

        public CoverLetter(int pageNum)
        {
            PageNum = pageNum;
        }

        public override void Print()
        {
            Console.WriteLine($"----- Cover Letter: Page {PageNum} -----");
            Console.WriteLine("Dear: " + AddressedTo);
            Console.WriteLine(BodyText);
            Console.WriteLine("Very Respectfully");
            Console.WriteLine($"{Signature}");
        }
    }
}
