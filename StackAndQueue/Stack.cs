using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalIdVerification.StackAndQueue
{
    public class Stack<T>
    {
        Node<T> Top { get; set; }

        public bool IsEmpty()
        {
            return Top == null;
        }

        public T Peek()
        {
            if (Top.Value != null)
            {
                return Top.Value;
            }
            return default(T); 
        }

        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            node.Next = Top;
            Top = node;
        }

        public T Pop()
        {
            if(Top.Value != null)
            {
                T value = Top.Value;
                Top = Top.Next;
                return value;
            }
            return default(T);
        }
    }
}
