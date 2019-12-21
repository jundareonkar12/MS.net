using System;
using System.Collections.Generic;
using System.Text;

namespace IF_Struct
{
    interface Interface1
    {//#region and #endregion used to hide data while developing program
        #region r1 
        void display();
        void display1()
        {
            Console.WriteLine("Hello User");
        }
        #endregion r1

    }
}
