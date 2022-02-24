using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode
{
    public class MainProgramData
    {
        public MainProgramData(List<Contributor> contributors,List<Project> projects)
        {
            Contributors = contributors;
            Projects = projects;
        }
        public List<Contributor> Contributors { get; set; } = new List<Contributor>();
        public List<Project> Projects { get; set; } = new List<Project>();


        public void Solve()
        {
            var projects = Projects.OrderBy(x => x.FinishTime)
                .ThenBy(x => x.Roles.Count);

            foreach (var project in projects)
            {
                var projectRoles = project.Roles;
                var availableContributors = Contributors.OrderBy(x => x.Skills.Count);
                availableContributors.Where(x => x.IsAssingnable(project));
                var contributor = availableContributors.FirstOrDefault();
                if(contributor==null) continue;
                
                

            }
                

            }

        }
    }
}
