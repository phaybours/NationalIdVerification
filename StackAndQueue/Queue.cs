using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification.StackAndQueue
{
    public class Queue<T>
    {
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public T Peek()
        {
            if(Head != null)
            {
                return Head.Value;
            }
            return default(T);
        }

        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if(Tail != null)
            {
                Tail.Next = node;
            }
            Tail = node;
            if(Head == null)
            {
                Head = node;
            }
        }

        public T Dequeue()
        {
            T data = default(T);

            if(Head != null)
            {
                data = Head.Value;
                Head = Head.Next;
            }
            else
            {
                Tail = null;
            }
            return data;
        }
    }
}
