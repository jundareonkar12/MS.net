using System;
using ClassLibrary1;//first u need to add ref then only u are able to include it
namespace Tester_proj
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person("onkar",12);//partial person
            p = new Person("pune");//partial person
            Console.WriteLine(p);
            p.Name = "sagar";
            Console.WriteLine(p);
            Class1 c1 = new Class1();//this class avilble from  class lib1 
            c1.display();
            Console.ReadLine();

        }
    }
}
