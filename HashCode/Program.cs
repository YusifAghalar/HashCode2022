// See https://aka.ms/new-console-template for more information

using HashCode;
using System;

var paths = new List<string>();
paths.Add("a_an_example.in.txt");
paths.Add("b_better_start_small.in.txt");
paths.Add("c_collaboration.in.txt");
paths.Add("d_dense_schedule.in.txt");
paths.Add("e_exceptional_skills.in.txt");
paths.Add("f_find_great_mentors.in.txt");


foreach (var item in paths)
{
    var fileReader = new FileReader();
    var problemData = fileReader.ReadFile(item);

    var result = problemData.Solve();

    fileReader.WriteFile(result);
     Console.WriteLine("Hello, World!" + item);
}

