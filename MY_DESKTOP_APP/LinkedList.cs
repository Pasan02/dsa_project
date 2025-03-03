using MY_DESKTOP_APP;
using Node1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class LinkedList
    {
        public Node? Head { get; set; }
        public Node? Tail { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public  int AddFront(Vehicle vehicle)
        {
            int added = 0;
            Node temp = new Node(vehicle);
            if (Head == null)
            {
                Head = temp;
                Tail = temp;
                ++added;
            }
            else
            {
                temp.Next = Head;
                Head = temp;
                ++added;
            }
            Count++;

            
            
                return added;
            
        }

        public int AddEnd(Vehicle vehicle)
        {
            int added = 0;
            Node temp = new Node(vehicle);

            if (Head == null)
            {
                Head = temp;
                Tail = temp;
                ++added;
            }
            else
            {
                Tail.Next = temp;
                Tail = temp;
                ++added;
            }
            Count++;
            return added;
        }

        public void AddAt(Vehicle vehicle, int index)
        {
            if (index < 0 || index > Count)
            {
                Console.WriteLine("Invalid Index");
                return;
            }

            if (index == 0)
            {
                AddFront(vehicle);
                return;
            }
            if (index == Count)
            {
                AddEnd(vehicle);
                return;
            }

            Node newNode = new Node(vehicle);
            Node current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            newNode.Next = current.Next;
            current.Next = newNode;
            Count++;
        }

        public void RemoveThis(Vehicle vehicle)
        {
            if (Head == null) return;

            if (Head.data == vehicle)
            {
                Head = Head.Next;
                Count--;
                if (Head == null) Tail = null;
                return;
            }

            Node current = Head;
            while (current.Next != null)
            {
                if (current.Next.data == vehicle)
                {
                    current.Next = current.Next.Next;
                    Count--;
                    if (current.Next == null) Tail = current;
                    return;
                }
                current = current.Next;
            }
        }

        public void DeleteAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("Invalid Index");
                return;
            }

            if (index == 0)
            {
                Head = Head.Next;
                if (Head == null) Tail = null;
            }
            else
            {
                Node current = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
                if (current.Next == null) Tail = current;
            }
            Count--;
        }

        public Node Search(Vehicle vehicle)
        {
            Node current = Head;

            while (current != null)
            {
                if (current.data == vehicle)
                {
                    return new Node(current.data);
                }
                current = current.Next;
            }

            return null;
        }

        public void Print()
        {
            Node current = Head;
            while (current != null)
            {
                Console.WriteLine(current.data);
                current = current.Next;
            }
        }
    }
}
