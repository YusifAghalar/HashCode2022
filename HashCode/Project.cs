using System.Collections.Generic;
using System.Security.AccessControl;

namespace HashCode
{
    public struct Project
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int FinishTime { get; set; }
        public int StartDay { get; set; }
        public int Score { get; set; }
        public List<Contributor> Contributors { get; set; } = new List<Contributor>();
        public List<Skill> Skills { get; set; } = new List<Skill>();
        //public List<Role> Roles { get; set; } = new List<Role>();       

    }
}