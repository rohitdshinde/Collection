using System;
using System.Collections;
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
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(22);
            //list.Add(3);
            //list.Add(4);
            //list.Add(2);
            //Console.WriteLine("count " + list.Count);

            //foreach (int a in list)
            //{
            //    Console.WriteLine(a);
            //};



            //list.Remove(4);
            // foreach (int b in list)
            // {
            //     Console.WriteLine(b);
            // }

            //list.Insert(4, 88);    // value is inserting in specific position
            //foreach (int c in list)
            //{
            //    Console.WriteLine(c);
            //}

            //list.Add(0);          // when value is add postion of value is last
            // foreach (int d in list)
            // {
            //     Console.WriteLine(d);
            // }


            //int m = list.Max();
            //Console.WriteLine(m);



            //Console.WriteLine(list.Max() + " " + list.Min()); 


            /////  ArrayList   //////

            //ArrayList alist=new ArrayList();
            //alist.Add(1);
            //alist.Add(12.3f);
            //alist.Add('a');
            //alist.Add("Pune");
            //foreach(var Spell in alist)
            //{
            //    Console.WriteLine(Spell);
            //}

            /////  SortedList   //////

            //SortedList<int,string> slist =new SortedList<int, string>();
            //slist.Add(1, "Pune");
            //slist.Add(9, "kolhapur");
            //slist.Add(6, "wai");
            //slist.Add(0, "Goa");
            //foreach (string s in slist.Values)
            //{
            //    Console.WriteLine(s);
            //}

            //foreach (int i in slist.Keys)
            //{
            //    Console.WriteLine(i);
            //}

            //foreach (var s in slist)
            //{
            //    Console.WriteLine(s.Key+ " " +s.Value);
            //}

            /////  stack   //////              First in last out(FILO)   //Last in First out (LIFO)


            //Stack<int> st=new Stack<int>();
            //st.Push(1);
            //st.Push(2);
            //st.Push(3);
            //st.Push(4);

            //Console.WriteLine("count"+st.Count);
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Count);

            //int n=st.Count;
            //for(int i=1; i<=n; i++)
            //{
            //    Console.WriteLine(st.Pop());
            //}
            //Console.ReadLine();


            //Queue<int> q = new Queue<int>();
            //q.Enqueue(9);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //int k = q.Count();
            //for(int i = 1; i <= k; i++)
            //{
            //    Console.WriteLine(q.Dequeue());
            //}


            //Dictionary<int,string> dt=new Dictionary<int,string>();
            //dt.Add(6, "Latur");
            //dt.Add(9, "gulbarga");
            //dt.Add(1, "satara");
            //foreach(var s in  dt)
            //{
            //    Console.WriteLine(s.Value+" "+s.Key);
            //}

            //Tuple<int, string, bool, float, int, char> t = new Tuple<int, string, bool, float, int, char>(101, "helo", true, 12.3f, 101, 'l');
            
                //Console.WriteLine(t);
                //Console.WriteLine(t.Item2);
                //Console.WriteLine(t.Item3);
                //Console.WriteLine(t.Item4);
                
            
        }
    }
}
