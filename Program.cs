class Program 
{
    static void Main(string[] args)
    { Lamp lamp = new Lamp("Living Room Lamp");
      lamp.TurnOn();
      lamp.SetBrightness(75);
      lamp.DisplayStatus();

      Thermostat thermostat = new Thermostat("Hallway Thermostat", 22);
      thermostat.TurnOn();
      thermostat.setTemperature(25);
      thermostat.DisplayStatus();

      securityCamera camera = new securityCamera("Front Door Camera");
      camera.TurnOn();
      camera.Startrecording();
      camera.DisplayStatus();
      camera.Stoprecording();
      camera.TurnOff();
      camera.DisplayStatus();
    }
}
