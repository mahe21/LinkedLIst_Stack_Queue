using System.Collections.Generic;

namespace LinkedListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("select any one option");
                Console.WriteLine("1 - linkedlistDemo");
                Console.WriteLine("2 - StackDemo");
                Console.WriteLine("3 - LinkedList_Node");
                Console.WriteLine("4 - LinkedList_Node to remove last element");
                Console.WriteLine("5 - LinkedList_Node to print sixe of the element");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        StackDemo stack = new StackDemo();
                        stack.Stack_Demo();
                        break;
                    case 2:
                        Linked_List_Demo linked_List_Demo = new Linked_List_Demo();
                        linked_List_Demo.Demo();
                        break;
                    case 3:
                        LinkedList_Node linkedList_Node_Demo = new LinkedList_Node();
                        linkedList_Node_Demo.Add(10);
                        linkedList_Node_Demo.Add(20);
                        linkedList_Node_Demo.Add(30);
                        linkedList_Node_Demo.RemoveLast();
                        linkedList_Node_Demo.Display();
                        break;
                    case 4:
                        LinkedList_Node linkedList_Node_Demo_Two = new LinkedList_Node();
                        linkedList_Node_Demo_Two.Add(10);
                        linkedList_Node_Demo_Two.Add(20);
                        linkedList_Node_Demo_Two.Add(30);
                        linkedList_Node_Demo_Two.RemoveLast();
                        linkedList_Node_Demo_Two.Display();
                        linkedList_Node_Demo_Two.Size();
                        break;
                    case 5:
                        LinkedList_Node linkedList_Node_Demo_Three = new LinkedList_Node();
                        linkedList_Node_Demo_Three.Add(10);
                        linkedList_Node_Demo_Three.Add(20);
                        linkedList_Node_Demo_Three.Add(30);
                        linkedList_Node_Demo_Three.Display();
                        linkedList_Node_Demo_Three.Size();
                        break;
                    

                    default:
                        Console.WriteLine("Invalid Option");
                        break;



                }

            }
            
        }
    }
}