using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public class MainProgramData
    {
        public List<Contributor> Contributors { get; set; } = new List<Contributor>();
        public List<Project> Projects { get; set; } = new List<Project>();


        public List<Project> Solve()
        {
            var projects = Projects.OrderBy(x => x.Duration).ThenBy(t=>t.Score).ToList();


            var resultProjects = new List<Project>();

            foreach (var project in projects)
            {
                foreach (var skill in project.Skills)
                {
                    var tempContributors = new List<Contributor>();
                    foreach (var cont in Contributors)
                    {
                        bool check = false;
                        foreach (var skl in cont.Skills)
                        {

                            if(skl.Name == skill.Name && skl.Level >= skill.Level)
                            {
                                check = true;
                                break;
                            }
                        }
                        if (check)
                        {
                            tempContributors.Add(cont);
                        }
                    }
                    tempContributors.OrderBy(t => t.Skills.First(s => s.Name == skill.Name).Level);

                    foreach (var validCont in tempContributors)
                    {
                        if (project.Contributors.Contains(validCont))
                        {
                            continue;
                        }
                        project.Contributors.Add(validCont);
                       
                        break;
                    }
                }
                if(project.Contributors.Count == project.Skills.Count)
                {
                    for (int i = 0; i < project.Contributors.Count; i++)
                    {
                        if (project.Skills[i].Level == project.Contributors[i].Skills.First(t => t.Name == project.Skills[i].Name).Level) 
                        {
                            var skill = project.Contributors[i].Skills.First(t => t.Name == project.Skills[i].Name);
                            skill.Level += 1;
                        }
                    }
                    resultProjects.Add(project);
                }
            }


            return resultProjects;

            //foreach (var project in projects)
            //{
            //    var projectRoles = project.Roles;
            //    var availableContributors = Contributors.OrderBy(x => x.Skills.Count);
            //    availableContributors.Where(x => x.IsAssingnable(project));
            //    var contributor = availableContributors.FirstOrDefault();
            //    if(contributor==null) continue;



            //}




        }
    }
}
