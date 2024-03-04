using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class abc
    {
        public void Display(int a)
        {
            Console.WriteLine(a);
        }
        public void Display(char a)
        {
            Console.WriteLine(a);
        }
        public void Display(string a)
        {
            Console.WriteLine(a);
        }
        public void Display(float a)
        {
            Console.WriteLine(a);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            abc a1 = new abc();
            a1.Display(10);
            a1.Display('a');
            a1.Display("Rohit");
            a1.Display(0.23f);
            Console.ReadLine();
        }
    }
}
