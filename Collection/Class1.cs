using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class ab<T>
    {
        public void Display(T a)
        {
            Console.WriteLine(a);
        }

    }
    class Class1
    {
            static void Main(string[] args)
            {
                ab<int> a1 = new ab<int>();
                ab<string> a2 = new ab<string>();
                ab<char> a3 = new ab<char>();
                ab<float> a4 = new ab<float>();
                a1.Display(10);
                a2.Display("Rohit");
                a3.Display('R');
                a4.Display(12.3f);
            }
    }
    
}
