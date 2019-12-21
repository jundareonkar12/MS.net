using System;

namespace IF_Struct
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Interface1 f1 = new Class1();
            f1.display();
            f1.display1();

            strcture1 s1=new strcture1(23);//struct data pushed on stack always
            s1.display();
            Console.ReadLine();
        }
    }
}
