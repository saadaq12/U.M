using System;

public class SmartDevice
{
    public string Name { get; set; }
    public bool Status { get; set; }

    public SmartDevice(string name)
    {
        this.Name = name;
        this.Status = false; // Default status is off
    }

    public void TurnOn()
    {
        Status = true;
        Console.WriteLine($"{Name} is now ON.");
    }

    public void TurnOff()
    {
        Status = false;
        Console.WriteLine($"{Name} is now OFF.");
    }

    public void DisplayStatus()
    {
        string state = Status ? "ON" : "OFF";
        Console.WriteLine($"{Name} is currently {state}.");
    }
    
}