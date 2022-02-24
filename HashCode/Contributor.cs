using System.Collections.Generic;

namespace HashCode
{
    public struct Contributor
    {
        public string Name { get; set; }
        public HashSet<Skill> Skills { get; set; }
        
    }
}