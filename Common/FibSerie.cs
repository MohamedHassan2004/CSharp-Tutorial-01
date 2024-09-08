using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class FibSerie: ISeries
    {
        int prev = 0;
        int curr = 1;

        public int Current { get { return curr; } }

        public void GetNext()
        {
            int tmp = curr;
            curr += prev ;
            prev = tmp;
            
        }

        public void Reset()
        {
            prev = 0;
            curr = 0;
        }
    }
}
