using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Common;
namespace Tutorial
{
    class MM
    {
        static void PrintSeries(ISeries ser)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ser.Current + " ");
                ser.GetNext();
            }
            ser.Reset();
            Console.WriteLine();
        }





    public static void Main(string[] args)
        {

            //Action
            Action<ISeries> Pr = PrintSeries;

            EvenSerie ser = new EvenSerie();
            Pr(ser);
            FibSerie ss = new FibSerie();
            Pr(ss);

            GCard card1 = GCard.SingleToneObj;
            GCard card2 = GCard.SingleToneObj;
            Console.WriteLine(card1.GetHashCode());
            Console.WriteLine(card2.GetHashCode());
            card1.Print();

            TypeA aa = new TypeA();
            TypeB bb = new TypeB();
            Console.WriteLine(aa.ToString());
            Console.WriteLine(bb.ToString());
            aa = new TypeB();
            Console.WriteLine(aa.ToString());


            int[] ints = { 1, 2, 3, 4, 5 };
            Console.WriteLine(string.Join(", ",ints));
            List<int> values = new List<int>(ints);
            values.ForEach((x)=> Console.Write($"{x} "));
            Console.WriteLine();

            TypeA typeA = new TypeA();
            Console.WriteLine(typeA.d);


        }
    }
}
