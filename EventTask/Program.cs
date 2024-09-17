namespace EventTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeatherStation w = new WeatherStation();
            Display d1 = new Display("Display 1");
            Display d2 = new Display("Display 2");
            w.TemperatureChanged += d1.OnTemperatureChanged;
            w.TemperatureChanged += d2.OnTemperatureChanged;
            w.Temperature = 25;
            w.Temperature = 30;
            w.TemperatureChanged -= d1.OnTemperatureChanged;
            w.Temperature = 35;
        }
    }
}
