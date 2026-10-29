namespace HelloInvestigation
{
    public class Greeting
    {
        public string Name { get; set; } = "runner";

        public string BuildMessage()
        {
            return $"Hello, world, {Name}!";
        }
    }
}