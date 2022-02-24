// See https://aka.ms/new-console-template for more information

using HashCode;
using System;

var fileReader = new FileReader();
var data = fileReader.ReadFile();
var problem = new MainProgramData(data.Contributors,data.Projects);

Console.WriteLine("Hello, World!");