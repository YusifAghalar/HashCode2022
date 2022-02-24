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
            var project = Projects.OrderBy(x => x.FinishTime)
                .ThenBy(x => x.Roles.Count);
            for (int i = 0; i < 1000000; i++)
            {
                var availableContributors=Contributors.Where(x=>x.)
            }

        }
    }
}
