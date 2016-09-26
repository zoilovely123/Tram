using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a = new Element<int>(4);
            Element<int> b= new Element<int>(6);
            Element<int> c = new Element<int>(8);
            List<int> list = new List<int>();
            list.addtail(a);
            list.addtail(b);
            list.addtail(c);
            list.PrintList();
            Console.ReadKey();
        }
    }
}
