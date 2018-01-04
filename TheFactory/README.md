# TheFactory Document Generator
### A project by Dustin Mundy

## About
TheFactory Document Ganerator is a series of classes designed to easily generate new SCP Documents following a specific format set forth by the members 05 Council.

These documents consist of a newly generated a Title, an Author, a text Body which is a 5 slot string array, an empty Meta section for storing redacted data, SCP number, an Object Class, a Special Containment Proceedures section and a Description.

Two document classes exist, one abstract Document class which only contains properties relevent to a broad range of documents. This is where the five slot string array is defined. SCPDocument is where the fun begins, SCP foundation related syntax is specified here. Special Containment Proceedures will actually fill slot 3 of the string array, and the description will fill slot 4. Slots One and Two belong to the SCP designation which is comprised of the randomly generated SCP Serial, and the SCP Object class which is one of Safe, Euclid, Keter, Neutralized, Explained or Thaumiel.

In order to access the program a user name must be specified which will be used as "Author" of each document you generate.

## Users
Simply run the program and follow the prompts!

## Developers

In order to generate a formatted SCP Document, first instantiate TheFactory.
```TheFactory ScipMaker = new TheFactory;```

Then use the PrintSCP method in order to generate your document.

