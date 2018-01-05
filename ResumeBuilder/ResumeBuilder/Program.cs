using System;
using System.Collections.Generic;
using ResumeBuilder.Classes;

namespace ResumeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Document> documents = new List<Document>();

            Profile micky = new Profile
            {
                ApplicantName = "Micky Mouse",
                Email = "Micky@Disney.com",
                Summary = "Professional Entertainer who makes people laugh!"
            };

            WorkHistory wh = new WorkHistory
            {
                JobTitle = "Entertainer",
                City = "TV",
                JobDescription = "Being cool"
            };

            Education edu = new Education {GraduationYear = 63498134};

            TraditionalResume tr = new TraditionalResume();
            tr.CreatePage();

            documents.Add(new TraditionalResume());

            foreach (var document in documents)
            {
                //Console.WriteLine($"Resume one Name: {document.Pages()}");
            }
        }
    }
}
