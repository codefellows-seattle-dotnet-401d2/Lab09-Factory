using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class CoverLetter : Page
    {
        public string AddressedTo { get; set; }
        public string BodyText { get; set; }
        public string Signature { get; set; }
    }
}
