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
        int id;
        string name;

        public TypeA(int _x , string _y)
        {
            id = _x;
            name = _y;
        }
        public TypeA(int _x): this(_x, "ss")
        { 
        }
        public TypeA()
        {
            id = 10;
            name = "Mohamed";
        }

        public void Print()
        {
            Console.WriteLine($"id : {this.id}\nname : {this.name}");
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}
