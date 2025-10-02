public class Lamp : SmartDevice
{
    public int Brightness { get; set; }

    public Lamp(string name) : base(name)
    {
        Brightness = 0; // Default brightness is 0
    }

    public void SetBrightness(int level)
    {
        if (level < 0 || level > 100)
        {
            Console.WriteLine("Brightness level must be between 0 and 100.");
            return;
        }
        Brightness = level;
        Console.WriteLine($"{Name} brightness set to {Brightness}%.");
    }
    public void Dim(int level)
    {
        if (level < 0 || level > 100)
        {
            Console.WriteLine("Dim level must be between 0 and 100.");
            return;
        }
        Brightness = level;
        Console.WriteLine($"{Name} dimmed to {Brightness}%.");
    }
}