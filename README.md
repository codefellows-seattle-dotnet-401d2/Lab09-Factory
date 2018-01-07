# Resume Builder using Factory Method Design Pattern
**Author**: Luay Younus
**Version**: 1.0

## Overview
This is a simple console application dedicated to create resumes/portfolios using C#. The program is interactive and can generate unique resumes for every user.

## Requirements to run the Application
- [Visual Studio 2017 Community with .NET Core 2.0 SDK](https://www.microsoft.com/net/core#windowscmd)
- [GitBash / Terminal](https://git-scm.com/downloads) or [GitHub Extension for Visual Studio](https://visualstudio.github.com)

## Getting Started
1. Clone the repository to your local machine.
2. Cd into the application directory where the `AppName.sln` exist.
3. Open the application using `Open/Start AppName.sln`.
4. Once Visual Studio is opened, you can Run the application by clicking on the Play button <img src="https://github.com/luayyounus/Lab02-Unit-Testing/blob/Lab02-Luay/WarCardGame/play-button.jpg" width="16">.
5. A welcome message with instructions will be displayed to teach you how to build the resume - step by step.

## Diagram
![InterfacesDiagram](FactoryDesignPattern.png?raw=true "Inheritance")

- "Resume" and "Portfolio" classes will inherit from the Abstract creator class "Document" using the concrete products inherited from "Page" class.
- A factory method exists to ask the user, which implementation they prefer to use.

## Program Experience
 The program will ask the user for their names, email, work experience, education and others. By the time all fields are complete, the resume will be presented in a nice and readable way.

## Architecture
 - C# Console Core application.
 - Inheritance is used to prove the design pattern.
 - Factory method design pattern
