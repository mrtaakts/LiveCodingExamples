using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveCodingExamples.Models
{
    public class Stack<T>
    {
        public List<T> items { get; set; }

        public int Count { get { return items.Count; } }

        public Stack()
        {
            items = new List<T>();
        }

        public void Push(T data)
        {
            items.Add(data);
        }

        public T Peek()
        {
            if (Count == 0)
                throw new InvalidOperationException("The stack is empty.");

            return items[Count - 1];
        }

        public T Pop()
        {
            if (Count == 0)
                throw new InvalidOperationException("The stack is empty."); // if there is no data 

            T top = items[Count - 1];
            items.RemoveAt(Count - 1);
            return top;

        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
