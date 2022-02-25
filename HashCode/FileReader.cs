using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public class FileReader
    {
        private string pat = "";
        
        private string outfilePath = "_output.txt";
        public FileReader()
        {

        }

        public MainProgramData ReadFile(string path)
        {
            pat = path;
            var mainProgramData = new MainProgramData();

            var fileText = File.ReadAllText(path);
            var fileTextLines = fileText.Split("\n");

            int contributorsCount = int.Parse(fileTextLines[0].Split(" ")[0]);
            int projectsCount = int.Parse(fileTextLines[0].Split(" ")[1]);

            var lineIndex = 1;

            // read contributors
            for (int i = 1; i <= contributorsCount; i++)
            {
                var lineData = fileTextLines[lineIndex++].Split(" ");

                var newContributor = new Contributor();
                newContributor.Name = lineData[0];

                var skillCount = int.Parse(lineData[1]);
                for(int j = 0; j < skillCount; j++)
                {
                    var skillLineData = fileTextLines[lineIndex++].Split(" ");
                    newContributor.Skills.Add(new Skill { Name = skillLineData[0], Level = int.Parse(skillLineData[1]) });
                }
                mainProgramData.Contributors.Add(newContributor);
            }

            //read Projects
            for (int i = 0; i < projectsCount; i++)
            {
                var lineData = fileTextLines[lineIndex++].Split(" ");

                var newProject = new Project
                {
                    Name = lineData[0],
                    Duration = int.Parse(lineData[1]),
                    Score = int.Parse(lineData[2]),
                    FinishTime = int.Parse(lineData[3])
                };

                var roleCount = int.Parse(lineData[4]);
                for (int j = 0; j < roleCount; j++)
                {
                    var roleLineData = fileTextLines[lineIndex++].Split(" ");
                    newProject.Skills.Add(new Skill { Name = roleLineData[0], Level = int.Parse(roleLineData[1]) });
                }
                mainProgramData.Projects.Add(newProject);
            }

            return mainProgramData;
        }

        public void WriteFile(List<Project> projects)
        {
            var resultString = new StringBuilder();
            resultString.AppendLine(projects.Count.ToString());
            foreach (var proj in projects)
            {
                resultString.AppendLine(proj.Name);
                foreach (var cont in proj.Contributors)
                {
                    resultString.Append(cont.Name + " ");
                }
                resultString.AppendLine();
            }

            File.WriteAllText("__" + pat, resultString.ToString());
        }
    }
}
