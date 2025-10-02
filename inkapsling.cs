public class Thermostat : SmartDevice
{
    //inkapsling
    private double temperature;

    public double Temperature
    {
        get { return temperature; }
        set
        {
            if (value < 5 && value <= 30)
            {
                Console.WriteLine("Temperature must be between 10 and 30 degrees Celsius.");
            }
            else
            {
                temperature = value;
                Console.WriteLine($"{Name} temperature set to {temperature}°C.");
            }
        }
    }

    public Thermostat(string name,  double initialTemperature) : base(name)
    {
        Temperature = initialTemperature;
    }
public void setTemperature(double newTemperature)
    {
        Temperature = newTemperature;
    }
}