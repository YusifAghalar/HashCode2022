namespace HashCode
{
    public class Skill
    {
        public string Name { get; set; }
        public int Level { get; set; }

        public override bool Equals(object? obj)
        {
            var other = (Skill) obj;
            return other.Name == Name && other.Level == Level;
        }
    }
}