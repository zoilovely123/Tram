using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class List<T>
    {
        Element<T> head;

        internal Element<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public List()
        {
            this.head = null;
            this.tail = null;
        }
        public void addfirst(Element<T> e)
        {
            e.Next = head;
            this.head = e;
        }
        public void addtail(Element<T> e)
        {
            if (tail == null) head = tail = e;
            else
            {
                tail.Next = e;
                this.tail = e;
            }
        }
        public void PrintList()
        {
            Element<T> point = head;
            while (point != null)
            {
                Console.Write(point.Data);
                point = point.Next;
            }
        }





        public Element<T> tail { get; set; }
    }
}
