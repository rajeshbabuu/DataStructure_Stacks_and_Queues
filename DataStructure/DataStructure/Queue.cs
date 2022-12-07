using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Queue
    {
        Node front;
        Node rear;
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            {
                this.rear = this.front = newNode;
            }
            else
            {
                this.rear.next = newNode;
                this.rear = newNode;
            }
        }


        public void Dequeue()
        {

            if (this.front == null)
            {
                Console.WriteLine("The Queue is empty");
                return;
            }
            Node temp = this.front;
            this.front = this.front.next;

            if (this.front == null)
            {
                this.rear = null;
            }

            Console.WriteLine("Element deleted is {0}", temp.value);
        }
        public void display()
        {
            int i = 1;
            int size = 0;
            Node temp = front;

            if (temp == null)
            {
                Console.WriteLine("Stack is empty");
            }
            while (temp != null)
            {
                Console.WriteLine($" {i} Elemen in stack is " + temp.value);
                temp = temp.next;
                size = i;
                i++;
            }
        }
    }
}
