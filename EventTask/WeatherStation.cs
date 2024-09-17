using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTask
{
    internal class WeatherStation
    {
        int temperature = 20;
        int OldTemp;
        int NewTemp;
        public int Temperature 
        {
            set{
                if (value != temperature)
                {
                    OldTemp = temperature;
                    temperature = value;
                    NewTemp = temperature;
                    OnTemperatureChanged();
                }
            }
            get => temperature;
        }

        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        protected virtual void OnTemperatureChanged()
        {
            TemperatureChanged?.Invoke(this, new TemperatureChangedEventArgs(OldTemp,NewTemp));
        }
    }
}
