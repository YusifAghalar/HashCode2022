using System.Collections.Generic;

namespace HashCode
{
    public class Contributor
    {
        public string Name { get; set; }
        public HashSet<Skill> Skills { get; set; } = new HashSet<Skill>();


        public bool IsAssignable(Project project)
        {
            
        }
        
    }
}