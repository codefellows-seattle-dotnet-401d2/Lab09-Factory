using System;
using System.Collections.Generic;
using ResumeBuilder.Classes;

namespace ResumeBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t --- Welcome to Resume Builder ---");

            // Creating Profile
            Console.WriteLine("\nEnter your name");
            string applicantName = Console.ReadLine();
            Console.WriteLine("\nEnter your Email Address");
            string email = Console.ReadLine();
            Console.WriteLine("\nEnter your Summary/Objective - 3 lines max.");
            string summary = Console.ReadLine();

            Profile profile = new Profile
            {
                ApplicantName = applicantName,
                Email = email,
                Summary = summary
            };


            // Creating Work History
            Console.WriteLine("\nEnter your job title");
            string jobTitle = Console.ReadLine();
            Console.WriteLine("\nEnter your current city");
            string city = Console.ReadLine();
            Console.WriteLine("\nEnter your job description");
            string jobDescription = Console.ReadLine();

            WorkHistory workHistory = new WorkHistory
            {
                JobTitle = jobTitle,
                City = city,
                JobDescription = jobDescription
            };


            // Creating Education
            Console.WriteLine("\nEnter your school name");
            string schoolName = Console.ReadLine();
            Console.WriteLine("\nEnter your course name");
            string courseName = Console.ReadLine();

            Education education = new Education
            {
                SchoolName = schoolName,
                Course = courseName
            };


            // Creating a Traditional Resume
            Resume traditionalResume = new Resume
            {
                Profile = profile,
                WorkHistory = workHistory,
                Education = education
            };

            // Adding the page to the document array
            traditionalResume.CreatePage();

            // Outputing the resume to the console
            Console.WriteLine($"\n\n\t{traditionalResume.Profile.ApplicantName} | Email: {traditionalResume.Profile.Email}" +
                              $"\n\n ---------------------- PROFILE -------------------------" +
                              $"\n {traditionalResume.Profile.Summary}" +
                              $"\n\n ------------------- WORK HISTORY -----------------------" +
                              $"\n {traditionalResume.WorkHistory.JobTitle} \t\t {traditionalResume.WorkHistory.City}" +
                              $"\n {traditionalResume.WorkHistory.JobDescription}" +
                              $"\n\n -------------------- EDUCATION -------------------------" +
                              $"\n {traditionalResume.Education.Course} | {traditionalResume.Education.SchoolName}" +
                              $"\n\n\n Thank you for using Resume Builder.");

            Console.ReadLine();
        }
    }
}
