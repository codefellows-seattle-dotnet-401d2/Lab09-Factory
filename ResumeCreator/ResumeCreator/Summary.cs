using System;
using System.Collections.Generic;
using System.Text;

namespace Product
{
    public class Summary : Page
    {
        public string FullName { get; set; } = "Ariel Pedraza";
        public string Email { get; set; } = "pedrazaa2@gmail.com";
        public string Phone { get; set; } = "123-456-7890";
        public string Address { get; set; } = "123 Spooner Street";
        public string Headline { get; set; } = ".Net Full Stack Web Developer";
        public string ShortSummary { get; set; } = "Highly qualified IT professional with 7 years experience.";

        public Summary(int pageNum)
        {
            PageNum = pageNum;
        }
    }
}
