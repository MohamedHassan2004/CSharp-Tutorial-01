using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class GCard
    {
        int id;
        GCard(int _id) { 
            id = _id;
        }
        public static GCard SingleToneObj { get; } = new GCard(10001); // single tone object

        public void Print()
        {
            Console.WriteLine("Card ID: " + id);
        }

    }

}
