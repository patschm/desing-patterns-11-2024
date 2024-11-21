namespace ObserverNS;

internal class Program
{
    static void Main(string[] args)
    {
        var sensor = new Sensor();
        sensor.Register(new Siren());
        sensor.Register(new FlashigLight());

        var light = new FlashigLight();
        sensor.OnChange += light.Notify;
        

        sensor.Detect("Cat");
        sensor.Detect("Dove");
    }
}