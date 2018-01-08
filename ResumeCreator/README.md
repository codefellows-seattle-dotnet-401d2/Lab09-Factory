# Resume Factory Console App

**Author**: Ariel R. Pedraza <br />
**Version**: 1.0.0

## Overview
<b>Purpose:</b><br />
This application demonstrates the use of the Factory Design Pattern by creating different types of Documents and each of which implements different types of Pages.

<b>Factory Design Layout:</b>
1. Product -- Page
2. Concrete Product -- Cover Letter, Summary, Work History, Education, References
3. Creator -- Document
4. Concrete Creator -- Classic Resume, Modern Resume

<b>Concrete Products called for each Concrete Creator:</b><br />
Classic Resume: Cover Letter, Work History, Education, References
<br />
Modern Resume: Summary, Work History, Education

## Getting Started
The following is required to run the program.
1. Visual Studio 2017 
2. The .NET desktop development workload enabled 

## Example Output

```
Testing Factory Design Pattern

Classic Resume:

----- Cover Letter: Page 1 -----
Dear: Microsoft
You should hire me because I know dank memes.
Very Respectfully, Ariel Pedraza - .NET Full Stack Web Dev

----- Work History: Page 2 -----
Microsoft - Support Engineer
4/15/2017 12:00:00 AM - 9/15/2017 12:00:00 AM
- Troubleshoot customer Microsoft Intune deployments
- Update service requests

----- Work History: Page 3 -----
University of Scranton - 12/15/2008 12:00:00 AM
Bachelor of Science
Major: Computer Information Systems
...
```

## Architecture
This application is created using ASP.NET Core 2.0 Console applicaitons. <br />
*Language*: C# <br />
*Type of Applicaiton*: Console Application <br />