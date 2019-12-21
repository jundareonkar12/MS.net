using System;
using System.Collections.Generic;
using System.Text;

namespace IF_Struct
{
    struct strcture1 : Interface1//struct is value type always pushed on stack
    {
        private int data;

        public strcture1(int d)//struct also support method and ctor
        {
            data = d;
        }
        public void display()
        {

            Console.Write("from struct dispaly");
            Console.WriteLine(data);
        }
    }
}
