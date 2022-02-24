using System.Linq;

namespace HashCode
{
    public class Role
    {
        public string Name { get; set; }
        public Skill Skill { get; set; }
        public Contributor Contributor { get; set; }
        public bool CanBeAssigned(Contributor contributor)
        {
            if (contributor.Skills.Any(x => x.Equals(Skill)))
                return true;
            return false;
        }

        public void Assign(Contributor contributor)
        {
            Contributor = contributor;
        }
    }
}