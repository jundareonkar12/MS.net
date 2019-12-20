using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicsLib;

namespace Tester
{
    public class Complex
    {
        private int real, imag;
        public Complex(int r, int i)
        {
            real = r;
            imag = i;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex result = new Complex(0, 0);
            result.real = c1.real + c2.real;
            result.imag = c1.imag + c2.imag;
            return result;

        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex result = new Complex(0, 0);
            result.real = c1.real - c2.real;
            result.imag = c1.imag - c2.imag;
            return result;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to .NET");
            int count = 45;
            count++;
            String company = "Transflower Learning Pvt. Ltd.";

            Person thePerson = new Person("Ravi", "Tambade", new DateTime(1975, 8, 18));
            Console.WriteLine(thePerson);
            Console.WriteLine(company);

            Complex c1 = new Complex(23, 45);
            Complex c2 = new Complex(5, 5);
            Complex c3 = c1 + c2;


            Shape theShape = new Line();
            theShape.Draw();






           Console.ReadLine();
        }
    }
}
