using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public  sealed class Line : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Line Draw");
        }
    }
}
