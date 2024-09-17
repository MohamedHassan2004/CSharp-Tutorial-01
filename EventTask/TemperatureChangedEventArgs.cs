using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTask
{
    internal class TemperatureChangedEventArgs:EventArgs
    {
        public int OldTemp { get; }
        public int NewTemp { get; }

        public TemperatureChangedEventArgs(int oldTemp, int newTemp)
        {
            OldTemp = oldTemp;
            NewTemp = newTemp;
        }
    }
}
