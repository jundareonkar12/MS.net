using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public class Line : Shape
    {
        private int spoint, epoint;
        public Line() { }
        public Line(int s,int e)
        {
            spoint = s;
            epoint = e;
        }
        public override void Draw()
        {
            Console.WriteLine("this is line");
        }
        public int Spoint
        {
            get { return spoint; }
            set { spoint = value; }
        }
        public int Epoint
        {
            get { return epoint; }
            set { epoint = value; }
        }
        public override string ToString()
        {
            return "spoint: " + spoint + " epoint: " + epoint;
        }
    }
}
