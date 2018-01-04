## Project Name
- Author: Jeff Martinez
- Version: 1.0.0

### Overview
This application showcases the Factory Method Design Pattern!  It accomplishes this by using the Factory Method attributes to create Resumes. This application will allow you to

### Getting Started
***The following is required to run the program:*** 
Visual Studio 2017
The .NET desktop development workload enabled
No External NuGet packages are required for this application.

***To Build this application:*** 
What are the steps that a user must take in order to build this app on their own machine and get it running?
1. Define what your Factory is going to look like
2. Use the design pattern Factory Method to create you factory.  In this case, we are building a Resume factory.
   Product(Pages)
   Concrete Products(Work History, Cover Letter, References)
   Creator(Person)
   Concrete Creator(Resume)
3. Create classes out of the seperate items in the Factory Method
4. Inherit the proper classes to complete the Factory Method structure
5. Create an instance of the class to build a new resume



### Example
```
RESUME BUILDER W/ FACTORY METHOD
Cover Letter for Microsoft

Work History:
Work Location 1
Work Location 2
Work Location 3

References:
Reference: Boss
Reference: Professor
Reference: Mentor

Cover Letter for Alaska Airlines

Work History:
Work Location 1
Work Location 2
Work Location 3

References:
Reference: Boss
Reference: Professor
Reference: Mentor
```

### Architecture
- This application is created using ASP.NET Core 2.0 Console applicaitons. 
- Language: C# 
- Type of Applicaiton: Console Application 

### Change Log

- 01-04-2018 10:00am - Added structure of the factory method 
- 01-04-2018 5:00pm - Added functionality to build resumes 
