using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_02_06
{
    class Stack
    {
        Node<City> head;

        public Stack()
        {
            head = null;
        }

        public void push(City item)
        {
            head = new Node<City>(item,head);

        }

        public string pop()
        {
            if (head == null)
                return null;
            T item = head._item;
            head = head._next;
            return item;

        }

        public IEnumerable<City> list()
        {
            Node<City> node = head;
            while (node!=null)
            {
                yield return node._item;
                node = node._next;

            }
        }

    }
}
