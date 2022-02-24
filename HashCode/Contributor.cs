using System.Collections.Generic;
using System.Linq;

namespace HashCode
{
    public class Contributor
    {
        public string Name { get; set; }
        public HashSet<Skill> Skills { get; set; } = new HashSet<Skill>();


        public bool IsAssingnable(Project project)
        {
            var projectRoles = project.Roles.Where(x => x.Contributor != null);
            var contributors = project.Contributors;
            var rolesMatching = projectRoles.Where(x => Skills.Any(s => s.Name == x.Skill.Name));

            foreach (var role in rolesMatching)
            {
                var mySkill = Skills.FirstOrDefault(x => x.Name == role.Skill.Name);
                if (mySkill.Level >= role.Skill.Level) return true;
            }

            return true;
        }
        
    }
}