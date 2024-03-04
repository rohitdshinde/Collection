using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class CollectionDemo
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();           
            list.Add(1);
            list.Add(22);
            list.Add(3);
            list.Add(4);
            list.Add(2);
            Console.WriteLine("count "+list.Count);

            foreach(int a in list)
            {
                Console.WriteLine(a);
            };



            /* list.Remove(4);
             foreach (int b in list)
             {
                 Console.WriteLine(b);
             }*/

            /*list.Insert(4, 88);    // value is inserting in specific position
            foreach (int c in list)
            {
                Console.WriteLine(c);
            }*/

            /* list.Add(0);          // when value is add postion of value is last
             foreach (int d in list)
             {
                 Console.WriteLine(d);
             }*/

            /*
            int m = list.Max();
            Console.WriteLine(m);


        
            Console.WriteLine(list.Max() + " " + list.Min()); */

           console.writeline("");

        }
    }
}
