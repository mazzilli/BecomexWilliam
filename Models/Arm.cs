namespace Models
{
    public class Arm
    {
        public Elbow RightElbow { get; set; } = Elbow.EmRepouso;
        public Elbow LeftElbow { get; set; } = Elbow.EmRepouso;

        public Fist RightFist { get; set; } = Fist.EmRepouso;
        public Fist LeftFist { get; set; } = Fist.EmRepouso;
    }
}
