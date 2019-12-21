using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;
using GraphicsLib;
namespace Tester
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int count = 10;
            count++;
            Console.WriteLine("Welcome to .NET");
            Complex c1=new Complex(20,30);
            Complex c2 = new Complex(1,2);
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Person P1 = new Person("ONKAR", "JUNDARE", new DateTime(2019 , 12 , 12), "jundare.onkar12@gmail.com", "pune");
            Console.WriteLine(P1);
            //Console.ReadLine();
            Person p = new Manager("ONKAR1", "JUNDARE", new DateTime(1996, 12, 12), "jundare.onkar12@gmail.com", "pune", "HR", new DateTime(2015, 05, 11), 24000, 2500, 3500, 2000, 131, 200);
            Console.WriteLine(p);
            p = new SalesManager("ONKAR2", "JUNDARE", new DateTime(1996, 12, 12), "jundare.onkar12@gmail.com", "pune", "HR", new DateTime(2015, 05, 11), 24000, 2500, 3500, 2000, 131,200,5000);
            Console.WriteLine(p);
            
            Shape s = new Line(12,23);
            s.Draw();
            Console.WriteLine(s);
            s = new Rectangle();
            s.Draw();
            Point point = new Point(12, 12);
            Console.WriteLine(point);
            Console.ReadLine();
        }
    }
    class Complex
    {
        private int real, img;
        private static int count = 0;
         public Complex( int r, int i)
        {
            count++;
            real = r;
            img = i;
        }
        public Complex()
        {
            count++;
        }
        ~Complex()
        {

        }

        public int Real//property
        {
            get { return real; } 
            set { real = value; }
        }
        public int Img
        {
            get { return img; }
            set { img = value; }
        }
        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public override string ToString()
        {
            return "Complex Number == "+real.ToString()+" + "+img.ToString();

        }
        public static Complex operator +(Complex c1,Complex c2)
        {
            Complex c3 = new Complex(0, 0);
            c3.real = c1.real + c2.real;
            c3.img = c1.img + c2.img;
            return c3;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(0, 0);
            c3.real = c1.real - c2.real;
            c3.img = c1.img - c2.img;
            return c3;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(0, 0);
            c3.real = c1.real * c2.real;
            c3.img = c1.img * c2.img;
            return c3;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex c3 = new Complex(0, 0);
            c3.real = c1.real / c2.real;
            c3.img = c1.img / c2.img;
            return c3;
        }
    }
    
}
