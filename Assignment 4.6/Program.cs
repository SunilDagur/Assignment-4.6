using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._6
{
    using System;

    public class SimpleStack<T>
    {
        private T[] items;
        private int top;

        public SimpleStack(int capacity)
        {
            items = new T[capacity];
            top = -1; 
        }

        
        public T this[int index]
        {
            get
            {
                if (index < 0 || index > top)
                {
                    throw new IndexOutOfRangeException();
                }
                return items[index];
            }
        }

        
        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
               
                Array.Resize(ref items, items.Length * 2);
            }
            items[++top] = item; 
        }

        
        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }
            return items[top--];
        }

       
        public int Count => top + 1;

       
        public bool IsEmpty => top == -1;
    }

    class Program
    {
        static void Main()
        {
            SimpleStack<int> stack = new SimpleStack<int>(5);

            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            
            Console.WriteLine(stack[0]); 
            Console.WriteLine(stack[2]); 

           
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop()); 

            Console.WriteLine($"Count: {stack.Count}");
            Console.WriteLine($"Is Empty: {stack.IsEmpty}"); 
        }
    }

}
