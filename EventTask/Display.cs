using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTask
{
    internal class Display
    {
        public string Name { get; }
        public Display(string Name)
        {
            this.Name = Name;
        }

        public void OnTemperatureChanged(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine($"{Name} display: Temperature changed from {e.OldTemp}°C to {e.NewTemp}°C");
        }
    }
}
