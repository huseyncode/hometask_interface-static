class Program
{
    static void Main(string[] args)

    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Yeni bir trafik işığı yaradırıq
        TrafficLight trafficLight = new TrafficLight();

        // İşığın rəngini dəyişirik və çap edirik
        for (int i = 0; i < 10; i++)
        {
            trafficLight.ChangeNextColor();
            Console.WriteLine($"İşığın cari rəngi: {trafficLight.Color}");
        }
    }
}

public enum LightColor
{
    Red,
    Yellow,
    Green
}

public class TrafficLight
{
    public LightColor Color { get; private set; }

    public TrafficLight()
    {
        Color = LightColor.Red;
    }

    public void ChangeNextColor()
    {
        switch (Color)
        {
            case LightColor.Red:
                Color = LightColor.Yellow;
                break;
            case LightColor.Yellow:
                Color = LightColor.Green;
                break;
            case LightColor.Green:
                Color = LightColor.Red;
                break;
        }
    }
}
