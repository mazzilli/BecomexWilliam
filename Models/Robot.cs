namespace Models
{
    public class Robot
    {
        public Arm Arms { get; set; } = new();

        public Head Head { get; set; } = new();

    }
}