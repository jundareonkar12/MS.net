using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GraphicsLib;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape myShape = new Rectangle();
            myShape.Draw();
            Console.ReadLine();
        }
    }
}
