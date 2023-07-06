using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDemo
{
    public class Linked_List_Demo
    {
        public void Demo()
        {
            LinkedList<int> demo = new LinkedList<int>();
            demo.AddLast(3);
            demo.AddLast(4);
            demo.AddLast(5);
            demo.AddLast(6);
            demo.AddLast(2);
            foreach (int valu in demo)
            {
                Console.WriteLine("Elements in linked list:" + valu);
                Console.WriteLine("No of elementsin list are:" + demo.Count);

            }
            Console.WriteLine("========================================================================");
            Console.WriteLine("Remove a elements form  list:" + demo.Remove(2));
            foreach (int valu in demo)
            {
                Console.WriteLine("Elements in listare =" + valu);
            }
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Count is " + demo.Count);
            Console.WriteLine("Remove a elements form list");
            demo.Remove(demo.Last);
            foreach (int valu in demo)
            {
                Console.WriteLine("Elements in list are -" + valu);

            }
            Console.WriteLine("===========================================================================");
            demo.Clear();
            foreach (int valu in demo)
            {
                Console.WriteLine("Delete elements form list -" + valu);

            }
            Console.WriteLine("==========================================================================");
            Console.WriteLine("Count is " + demo.Count);
            if (demo.Contains(3) == true)
            {
                Console.WriteLine("The element was present");
            }
            else
            {
                Console.WriteLine("The element is not found");
            }

        }
    }
}
