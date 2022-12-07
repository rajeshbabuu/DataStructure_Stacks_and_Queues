using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Stack
    {

        public Node top;
        public Stack()
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed to stack", data);
        }

        public void pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine("Popped Element = " + top.value);
            top = top.next;
        }

        public void peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("Peak element is :" + top.value);
        }
        public void Display()
        {

            int i = 1;
            int Size = 0;
            Node temp = top;

            Console.WriteLine();
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($" {i} Element in Stack is : " + temp.value);
                temp = temp.next;
                Size = i;
                i++;
            }
            Console.WriteLine("\nTotal Elements in Stack is : " + Size);
        }
    }
}
