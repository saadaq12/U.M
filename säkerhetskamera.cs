using System.Security.Cryptography.X509Certificates;

public class securityCamera : SmartDevice
{
    public bool isrecording { get; set; }
    public securityCamera(string name) : base(name)
    {
        // Constructor body can be empty or contain initialization logic
    }

    public void Startrecording()
    {
        isrecording = true;
        Console.WriteLine($"{Name} has started recording.");
    }
    public void Stoprecording()
    {
        isrecording = false;
        Console.WriteLine($"{Name} has stopped recording.");

    }
    
    
}