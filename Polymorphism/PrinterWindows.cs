using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class PrinterWindows
    {
        public virtual void Show()
        {
            Console.WriteLine("Printer windows display dimension: 9.5x12");
        }

        public virtual void Print()
        {
            Console.WriteLine("Printer windows printing...");
        }
    }

    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension: 10x11");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }

    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension: 9.5x12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }

    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon display dimension: 12x12");
        }

        public override void Print()
        {
            Console.WriteLine("Canon printer printing...");
        }
    }
}
