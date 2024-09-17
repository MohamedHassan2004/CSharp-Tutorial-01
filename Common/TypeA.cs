using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeA
    {
        public int d => 7; // read-only property
        public int A { get; set; }
        public TypeA(int _A = 0) { A = _A; }
        public void StaticallyBindedShow()
        {
            Console.WriteLine("I am Base");
        }
    }
    public class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int _A = 0, int _B = 0) : base(_A)
        {
            B = _B;
        }
    }
}
